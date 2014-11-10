using LinqToTwitter;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

namespace LiveSplit.UI.Components
{
    public partial class LiveShareSettings : UserControl
    {
        public InMemoryCredentials Credentials { get; set; }
        public PinAuthorizer Authorizer { get; set; }

        public String Split { get; set; }
        public String SplitAheadGaining { get; set; }
        public String SplitAheadLosing { get; set; }
        public String SplitBehindGaining { get; set; }
        public String SplitBehindLosing { get; set; }
        public String BestSegment { get; set; }
        public String UndoSplit { get; set; }
        public String SkipSplit { get; set; }
        public String PersonalBest { get; set; }
        public String NotAPersonalBest { get; set; }
        public String Reset { get; set; }
        public String Pause { get; set; }
        public String Resume { get; set; }
        public String StartTimer { get; set; }

        public LiveShareSettings()
        {
            InitializeComponent();

            Credentials = new InMemoryCredentials
            {
                ConsumerKey = "U8G6Np4aEBUgiklBHB17k6Zp0",
                ConsumerSecret = "hase0Q2DtEnmDfkAVJdbqkwA5BbmsEOTtILoUFajMAJe8yWTJv"
            };

            InitAuthorizer();

            Split = string.Empty;
            SplitAheadGaining = string.Empty;
            SplitAheadLosing = string.Empty;
            SplitBehindGaining = string.Empty;
            SplitBehindLosing = string.Empty;
            BestSegment = string.Empty;
            UndoSplit = string.Empty;
            SkipSplit = string.Empty;
            PersonalBest = string.Empty;
            NotAPersonalBest = string.Empty;
            Reset = string.Empty;
            Pause = string.Empty;
            Resume = string.Empty;
            StartTimer = string.Empty;

            txtSplitPath.DataBindings.Add("Text", this, "Split");
            txtSplitAheadGaining.DataBindings.Add("Text", this, "SplitAheadGaining");
            txtSplitAheadLosing.DataBindings.Add("Text", this, "SplitAheadLosing");
            txtSplitBehindGaining.DataBindings.Add("Text", this, "SplitBehindGaining");
            txtSplitBehindLosing.DataBindings.Add("Text", this, "SplitBehindLosing");
            txtBestSegment.DataBindings.Add("Text", this, "BestSegment");
            txtUndo.DataBindings.Add("Text", this, "UndoSplit");
            txtSkip.DataBindings.Add("Text", this, "SkipSplit");
            txtPersonalBest.DataBindings.Add("Text", this, "PersonalBest");
            txtNotAPersonalBest.DataBindings.Add("Text", this, "NotAPersonalBest");
            txtReset.DataBindings.Add("Text", this, "Reset");
            txtPause.DataBindings.Add("Text", this, "Pause");
            txtResume.DataBindings.Add("Text", this, "Resume");
            txtStartTimer.DataBindings.Add("Text", this, "StartTimer");
        }

        public XmlNode GetSettings(XmlDocument document)
        {
            var settingsNode = document.CreateElement("Settings");
            settingsNode.AppendChild(ToElement(document, "Version", Assembly.GetExecutingAssembly().GetName().Version.ToString(2)));
            settingsNode.AppendChild(ToElement(document, "Credentials", Credentials));
            settingsNode.AppendChild(ToElement(document, "Split", Split));
            settingsNode.AppendChild(ToElement(document, "SplitAheadGaining", SplitAheadGaining));
            settingsNode.AppendChild(ToElement(document, "SplitAheadLosing", SplitAheadLosing));
            settingsNode.AppendChild(ToElement(document, "SplitBehindGaining", SplitBehindGaining));
            settingsNode.AppendChild(ToElement(document, "SplitBehindLosing", SplitBehindLosing));
            settingsNode.AppendChild(ToElement(document, "BestSegment", BestSegment));
            settingsNode.AppendChild(ToElement(document, "UndoSplit", UndoSplit));
            settingsNode.AppendChild(ToElement(document, "SkipSplit", SkipSplit));
            settingsNode.AppendChild(ToElement(document, "PersonalBest", PersonalBest));
            settingsNode.AppendChild(ToElement(document, "NotAPersonalBest", NotAPersonalBest));
            settingsNode.AppendChild(ToElement(document, "Reset", Reset));
            settingsNode.AppendChild(ToElement(document, "Pause", Pause));
            settingsNode.AppendChild(ToElement(document, "Resume", Resume));
            settingsNode.AppendChild(ToElement(document, "StartTimer", StartTimer));
            return settingsNode;
        }

        public void SetSettings(XmlNode settings)
        {
            var element = (XmlElement)settings;

            if (element["Credentials"] != null)
            {
                Credentials.Load(element["Credentials"].InnerText);
                InitAuthorizer();
            }

            Split = element["Split"].InnerText;
            SplitAheadGaining = element["SplitAheadGaining"].InnerText;
            SplitAheadLosing = element["SplitAheadLosing"].InnerText;
            SplitBehindGaining = element["SplitBehindGaining"].InnerText;
            SplitBehindLosing = element["SplitBehindLosing"].InnerText;
            BestSegment = element["BestSegment"].InnerText;
            UndoSplit = element["UndoSplit"].InnerText;
            SkipSplit = element["SkipSplit"].InnerText;
            PersonalBest = element["PersonalBest"].InnerText;
            NotAPersonalBest = element["NotAPersonalBest"].InnerText;
            Reset = element["Reset"].InnerText;
            Pause = element["Pause"].InnerText;
            Resume = element["Resume"].InnerText;
            StartTimer = element["StartTimer"].InnerText;
        }

        private XmlElement ToElement<T>(XmlDocument document, String name, T value)
        {
            var element = document.CreateElement(name);
            element.InnerText = value.ToString();
            return element;
        }

        private void InitAuthorizer()
        {
            Authorizer = new PinAuthorizer
            {
                Credentials = Credentials,
                GoToTwitterAuthorization = pageLink => Process.Start(pageLink),
                GetPin = () =>
                {
                    using (PinConfimation dialog = new PinConfimation())
                    {
                        return dialog.ShowDialog() == DialogResult.OK ? dialog.Pin : null;
                    }
                }
            };

            EnableControls();
        }

        private void EnableControls()
        {
            bool enabled = Authorizer.IsAuthorized;
            btnAuthorize.Enabled = !enabled;
        }

        private void InsertMacroToRichTextBox(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            RichTextBox control = cmsInsertMacro.SourceControl as RichTextBox;

            control.Text = control.Text.Insert(control.SelectionStart, item.Tag.ToString());
        }

        private void btnAuthorize_Click(object sender, EventArgs e)
        {
            Authorizer.Authorize();
            EnableControls();
        }
    }
}
