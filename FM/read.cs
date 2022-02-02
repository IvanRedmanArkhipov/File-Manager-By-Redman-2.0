using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM
{
    internal class read : main
    {
        public static void Read(string[] words)
        {
            Console.Clear();
            RemoveAt(ref words, 0);
            string words1 = string.Join(" ", words);
            string s = "";
            var s1 = "";
            var i = 0;
            StreamReader sr = new StreamReader(dir + words1);

            Console.WriteLine("| " + words1);
            Console.WriteLine("");

            while (sr.EndOfStream != true)
            {
                s = sr.ReadLine();

                Console.WriteLine(s);

                s1 += s;

                i++;
            }

            char[] ch = s1.ToCharArray();

            line.print(52);
            Console.WriteLine("Инофрмация:");
            Console.WriteLine("Количество строк: " + i);
            Console.WriteLine("Количество символов: " + ch.Length);

            sr.Close();

            line.print(58);
            
            Console.ReadKey();
        }
    }
}
