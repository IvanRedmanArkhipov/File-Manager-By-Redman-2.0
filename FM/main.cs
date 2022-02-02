using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace FM
{
    internal class main
    {
        public static int error = 0;
        public static string errorMessage = "";
        public static string dir = ConfigurationManager.AppSettings["drctr"];
        public static int dsk = Convert.ToInt32(ConfigurationManager.AppSettings["dsk"]);
        public static Configuration currentConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        protected static void RemoveAt(ref string[] array, int index)
        {
            string[] newArray = new string[array.Length - 1];

            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }

            for (int i = index + 1; i < array.Length; i++)
            {
                newArray[i - 1] = array[i];
            }
            array = newArray;
        }
    }
}
