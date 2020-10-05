using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Killcount
{
    public partial class ConfigPanel : UserControl
    {
        /**
         * Map of kills
         */
        private Dictionary<String, Int32> KillMap;
        public ConfigPanel()
        {
            KillMap = new Dictionary<string, int>();
            InitializeComponent();
        }

        public void UpdateKills()
        {
            // Create the kill text
            String KillText = "";
            foreach (var Kill in KillMap.OrderByDescending(key => key.Value))
            {
                if (filter.Text.Length != 0)
                {
                    Match mobfilter = Regex.Match(Kill.Key, filter.Text);

                    if (!mobfilter.Success)
                    {
                        continue;
                    }
                }

                KillText += String.Format("{0}: {1}\r\n", Kill.Key, Kill.Value.ToString());
            }

            // Set the text
            Kills.Text = KillText;
        }
            
        public void AddKill(String Mob)
        {
            // Add to existing mob
            if (KillMap.ContainsKey(Mob))
            {
                KillMap[Mob]++;
            }
            
            // Add new kill
            else
            {
                KillMap.Add(Mob, 1);
            }
            
            // Update the text
            UpdateKills();
        }

        public void ClearKills()
        {
            KillMap.Clear();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ClearKills();
            UpdateKills();
        }

        private void filter_TextChanged(object sender, EventArgs e)
        {
            UpdateKills();
        }
    }
}