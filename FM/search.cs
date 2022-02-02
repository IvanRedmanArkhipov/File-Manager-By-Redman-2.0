using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM
{
    internal class search
    {
        public static void Search(string[] words)
        {
            Console.Clear();
            Console.WriteLine("Поиск по результату " + words[1] + " в " + main.dir + ":");

            string[] allFoundFiles = Directory.GetFiles(main.dir, words[1], SearchOption.AllDirectories);

            foreach (string file in allFoundFiles)
            {
                Console.WriteLine("     | {0}", file);
            }

            line.print(58);

            Console.ReadKey();
        }
    }
}
