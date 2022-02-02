using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace FM
{
    internal class Logger
    {
        public static void WriteLine(string message)
        {
            using StreamWriter sw = new(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\random_name_exception.txt", true);
            sw.WriteLine(String.Format("{0,-23} {1}", DateTime.Now.ToString() + ":", message));
        }
    }
}
