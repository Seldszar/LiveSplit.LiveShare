using LinqToTwitter;
using LiveSplit.Model;
using LiveSplit.TimeFormatters;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.UI.Components
{
    public class LiveShare : LogicComponent, IDeactivatableComponent
    {
        public override string ComponentName
        {
            get { return "Live Share"; }
        }

        public LiveShareSettings Settings { get; set; }
        public LiveSplitState State { get; set; }

        public bool Activated { get; set; }

        protected ITimeFormatter DeltaFormatter { get; set; }
        protected ITimeFormatter TimeFormatter { get; set; }

        public LiveShare(LiveSplitState state)
        {
            Settings = new LiveShareSettings();
            State = state;

            Activated = true;

            DeltaFormatter = new PreciseDeltaFormatter(TimeAccuracy.Hundredths);
            TimeFormatter = new RegularTimeFormatter(TimeAccuracy.Hundredths);

            State.OnStart += State_OnStart;
            State.OnSplit += State_OnSplit;
            State.OnSkipSplit += State_OnSkipSplit;
            State.OnUndoSplit += State_OnUndoSplit;
            State.OnPause += State_OnPause;
            State.OnResume += State_OnResume;
            State.OnReset += State_OnReset;
        }

        public override Control GetSettingsControl(LayoutMode mode)
        {
            return Settings;
        }

        public override XmlNode GetSettings(XmlDocument document)
        {
            return Settings.GetSettings(document);
        }

        public override void SetSettings(XmlNode settings)
        {
            Settings.SetSettings(settings);
        }

        public override void RenameComparison(string oldName, string newName) { }

        public override void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode) { }

        public override void Dispose() 
        {
            State.OnStart -= State_OnStart;
            State.OnSplit -= State_OnSplit;
            State.OnSkipSplit -= State_OnSkipSplit;
            State.OnUndoSplit -= State_OnUndoSplit;
            State.OnPause -= State_OnPause;
            State.OnResume -= State_OnResume;
            State.OnReset -= State_OnReset;
        }

        private void State_OnStart(object sender, EventArgs e)
        {
            UpdateStatus(Settings.StartTimer);
        }

        private void State_OnSplit(object sender, EventArgs e)
        {
            if (State.CurrentPhase == TimerPhase.Ended)
            {
                if (State.Run.Last().PersonalBestSplitTime[State.CurrentTimingMethod] == null || State.Run.Last().SplitTime[State.CurrentTimingMethod] < State.Run.Last().PersonalBestSplitTime[State.CurrentTimingMethod])
                {
                    UpdateStatus(Settings.PersonalBest);
                }
                else
                {
                    UpdateStatus(Settings.NotAPersonalBest);
                }
            }
            else
            {
                string status = Settings.Split;
                int splitIndex = State.CurrentSplitIndex - 1;
                TimeSpan? delta = LiveSplitStateHelper.GetLastDelta(State, splitIndex, State.CurrentComparison, State.CurrentTimingMethod);

                if (delta != null)
                {
                    if (delta < TimeSpan.Zero)
                    {
                        status = Settings.SplitAheadGaining;

                        if (LiveSplitStateHelper.GetPreviousSegment(State, splitIndex, false, false, true, State.CurrentComparison, State.CurrentTimingMethod) > TimeSpan.Zero)
                        {
                            status = Settings.SplitAheadLosing;
                        }
                    }
                    else
                    {
                        status = Settings.SplitBehindLosing;

                        if (LiveSplitStateHelper.GetPreviousSegment(State, splitIndex, false, false, true, State.CurrentComparison, State.CurrentTimingMethod) < TimeSpan.Zero)
                        {
                            status = Settings.SplitBehindGaining;
                        }
                    }
                }

                TimeSpan? curSegment = LiveSplitStateHelper.GetPreviousSegment(State, splitIndex, false, true, true, State.CurrentComparison, State.CurrentTimingMethod);

                if (curSegment != null)
                {
                    if (State.Run[splitIndex].BestSegmentTime[State.CurrentTimingMethod] == null || curSegment < State.Run[splitIndex].BestSegmentTime[State.CurrentTimingMethod])
                    {
                        status = Settings.BestSegment;
                    }
                }

                UpdateStatus(status);
            }
        }

        private void State_OnSkipSplit(object sender, EventArgs e)
        {
            UpdateStatus(Settings.SkipSplit);
        }

        private void State_OnUndoSplit(object sender, EventArgs e)
        {
            UpdateStatus(Settings.UndoSplit);
        }

        private void State_OnPause(object sender, EventArgs e)
        {
            UpdateStatus(Settings.Pause);
        }

        private void State_OnResume(object sender, EventArgs e)
        {
            UpdateStatus(Settings.Resume);
        }

        private void State_OnReset(object sender, TimerPhase value)
        {
            if (value != TimerPhase.Ended)
            {
                UpdateStatus(Settings.Reset);
            }
        }

        private void UpdateStatus(string status)
        {
            Task.Factory.StartNew(() =>
            {
                if (Settings.Authorizer.IsAuthorized)
                {
                    if (!string.IsNullOrWhiteSpace(status))
                    {
                        status = status.Replace("$gameName", State.Run.GameName);
                        status = status.Replace("$categoryName", State.Run.CategoryName);
                        status = status.Replace("$attemptCount", State.Run.AttemptCount.ToString());

                        if (State.CurrentSplitIndex > 0)
                        {
                            int splitIndex = State.CurrentSplitIndex - 1;
                            TimeSpan? delta = LiveSplitStateHelper.GetLastDelta(State, splitIndex, State.CurrentComparison, State.CurrentTimingMethod);

                            status = status.Replace("$splitName", State.Run[splitIndex].Name);
                            status = status.Replace("$splitTime", TimeFormatter.Format(State.Run[splitIndex].SplitTime[State.CurrentTimingMethod]));
                            status = status.Replace("$deltaTime", DeltaFormatter.Format(delta));
                        }

                        using (var twitter = new TwitterContext(Settings.Authorizer))
                        {
                            if (status.Length > 140)
                            {
                                status = status.Wrap(137).First();

                                twitter.UpdateStatus(status + "...");
                            }
                            else
                            {
                                twitter.UpdateStatus(status);
                            }
                        }
                    }
                }
            });
        }
    }
}
