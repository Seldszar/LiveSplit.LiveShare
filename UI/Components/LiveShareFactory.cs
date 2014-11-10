using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;
using System.Reflection;

[assembly: ComponentFactory(typeof(LiveShareFactory))]

namespace LiveSplit.UI.Components
{
    public class LiveShareFactory : IComponentFactory
    {
        public ComponentCategory Category
        {
            get { return ComponentCategory.Other; }
        }

        public string ComponentName
        {
            get { return "Live Share"; }
        }

        public IComponent Create(LiveSplitState state)
        {
            return new LiveShare(state);
        }

        public string Description
        {
            get { return "Share in real time your run progression."; }
        }

        public string UpdateName
        {
            get { return ComponentName; }
        }

        public string UpdateURL
        {
            get { return "http://livesplit.org/update/"; }
        }

        public Version Version
        {
            get { return Assembly.GetExecutingAssembly().GetName().Version; }
        }

        public string XMLURL
        {
            get { return "http://livesplit.org/update/Components/noupdates.xml"; }
        }
    }
}
