﻿using System.IO;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Controller.Plugins;

namespace OneDrive.Configuration
{
    public class ConfigurationPage : IPluginConfigurationPage
    {
        public string Name
        {
            get { return Constants.Name.Replace(" ", ""); }
        }

        public ConfigurationPageType ConfigurationPageType
        {
            get { return ConfigurationPageType.PluginConfiguration; }
        }

        public IPlugin Plugin
        {
            get { return OneDrive.Plugin.Instance; }
        }

        public Stream GetHtmlStream()
        {
            var type = GetType();
            return type.Assembly.GetManifestResourceStream(type.Namespace + ".configPage.html");
        }
    }
}
