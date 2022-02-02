using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FM
{
    internal class info
    {
        public static void Write()
        {
            DirectoryInfo di = new(main.dir);
            Console.WriteLine("Имя каталога: " + di.Name);
            try
            {
                Console.WriteLine("Занято: " + GetDirSize(main.dir) + " байт");
            }
            catch
            {
                try
                {
                    if (main.dir.Length == 3)
                    {
                        DriveInfo drives = new(main.dir);
                        Console.WriteLine("Занято: " + (drives.TotalSize - drives.TotalFreeSpace) + " байт");
                    }
                    else
                    {
                        Console.WriteLine("Размер не определён");
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
            }
            Console.WriteLine("Атрибуты: " + di.Attributes);
        }
        static long GetDirSize(string path)
        {
            long size = 0;
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
                size += (new FileInfo(file)).Length;
            string[] dirs = Directory.GetDirectories(path);
            foreach (string dir in dirs)
                size += GetDirSize(dir);
            return size;
        }
    }
}
