using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Advanced_Combat_Tracker;

[assembly: AssemblyTitle("Kill counter plugin")]
[assembly: AssemblyDescription("A plugin for ACT to count kills")]
[assembly: AssemblyCompany("Roses of Eorzea")]
[assembly: AssemblyCopyright("Mireiawen Rose")]
[assembly: AssemblyVersion("0.5.0")]

namespace Killcount
{
    public class Killcount : IActPluginV1
    {
        private Label ACTStatus;
        private ConfigPanel Config;
        
        public void InitPlugin(TabPage pluginScreenSpace, Label pluginStatusText)
        {
            ACTStatus = pluginStatusText;
            ACTStatus.Text = "Initializing...";
            Config = new ConfigPanel();
            pluginScreenSpace.Controls.Add(Config);
            Config.Dock = DockStyle.Fill;

            ActGlobals.oFormActMain.OnLogLineRead += LogLineRead;
                
            ACTStatus.Text = "Initialized.";
        }

        public void DeInitPlugin()
        {
            ActGlobals.oFormActMain.OnLogLineRead -= LogLineRead;
            ACTStatus.Text = "Terminated.";
        }

        void LogLineRead(bool isImport, LogLineEventArgs args)
        {
            Match defeat = Regex.Match(args.originalLogLine, @"You defeat the (?<mob>.+)\.$");
            if (defeat.Success)
            {
                Config.AddKill(defeat.Groups["mob"].Value);
            }

            defeat = Regex.Match(args.originalLogLine, @".+ defeats the (?<mob>.+)\.$");
            if (defeat.Success)
            {
                Config.AddKill(defeat.Groups["mob"].Value);
            }
        }
    }
}