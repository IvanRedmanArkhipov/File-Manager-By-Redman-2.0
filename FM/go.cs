using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FM
{
    internal class go : main
    {
        public static void Go(string[] words)
        {
            if (words[1] == "..")
            {
                if (dir.Length <= 3)
                {
                    main.dsk = 1;
                    main.currentConfig.AppSettings.Settings["dsk"].Value = Convert.ToString(main.dsk);
                    main.currentConfig.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                }
                else
                {
                    string[] dirs = dir.Split(@"\");
                    main.RemoveAt(ref dirs, dirs.Length - 1);
                    main.RemoveAt(ref dirs, dirs.Length - 1);
                    main.dir = (string.Join(@"\", dirs) + @"\");
                }
            }
            else if (words[1] == "to")
            {
                main.RemoveAt(ref words, 0);
                main.RemoveAt(ref words, 0);
                string words1 = string.Join(" ", words);
                char[] words2 = words1.ToCharArray();
                if (words2[words2.Length - 1] == Convert.ToChar(@"\"))
                {
                    main.dir = words1;
                }
                else
                {
                    main.dir = (words1 + @"\");
                }
            }
            else
            {
                main.RemoveAt(ref words, 0);
                string words1 = string.Join(" ", words);
                main.dir = (dir + words1 + @"\");
            }
            main.currentConfig.AppSettings.Settings["drctr"].Value = main.dir;
            main.currentConfig.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
