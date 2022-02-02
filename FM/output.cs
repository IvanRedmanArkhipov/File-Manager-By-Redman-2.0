using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FM
{
    internal class output
    {
        public int list = 1;
        public void Output()
        {
            if (main.dsk == 0)
            {
                var minElement = list * 50 - 50;
                var maxElement = minElement + 50 - 1;
                List<string> dirnames = new();
                try
                {
                    DirectoryInfo dirInfo = new(main.dir);
                    DirectoryInfo[] dirInfos = dirInfo.GetDirectories("*.*");
                    FileInfo[] fileNames = dirInfo.GetFiles("*.*");

                    foreach (DirectoryInfo d in dirInfos)
                    {
                        dirnames.Add(d.Name);
                    }

                    foreach (FileInfo fi in fileNames)
                    {
                        dirnames.Add(fi.Name);
                    }
                }
                catch (Exception e)
                {
                    main.error = 1;
                    main.errorMessage = e.Message;
                    Logger.WriteLine(e.Message);

                    main.dsk = 1;
                    main.currentConfig.AppSettings.Settings["dsk"].Value = Convert.ToString(main.dsk);
                    main.currentConfig.Save(ConfigurationSaveMode.Modified);
                    ConfigurationManager.RefreshSection("appSettings");
                }

                Console.WriteLine($"| {main.dir} ");

                for (var i = 0; (i < dirnames.Count) & (i <= maxElement); i++)
                {
                    if (i >= minElement)
                    {
                        Console.WriteLine("     | {0}", dirnames[i]);
                    }
                }

                if (dirnames.Count > 50)
                {
                    if (maxElement <= dirnames.Count)
                    {
                        Console.WriteLine($"Элементы {minElement + 1} - {maxElement + 1} / {dirnames.Count}");
                    }
                    else
                    {
                        Console.WriteLine($"Элементы {minElement + 1} - {dirnames.Count} / {dirnames.Count}");
                    }
                }
            }

            if (main.dsk == 1)
            {
                Console.Clear();
                Console.WriteLine("Выберите диск:");
                Console.WriteLine("При выборе диска \"go\" писать не нужно");
                string[] Drives = Environment.GetLogicalDrives();
                foreach (string s in Drives)
                {
                    Console.WriteLine(s);
                }
                line.print(52);
                var commandd = Console.ReadLine();
                if (commandd == "help")
                {
                    help.Help();
                }
                string[] wordds = commandd.Split(' ');
                main.dir = wordds[0];
                main.dsk = 0;

                Console.Clear();
                output op = new();
                op.Output();

                main.currentConfig.AppSettings.Settings["dsk"].Value = Convert.ToString(main.dsk);
                main.currentConfig.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                main.currentConfig.AppSettings.Settings["drctr"].Value = Convert.ToString(main.dir);
                main.currentConfig.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }
    }
}
