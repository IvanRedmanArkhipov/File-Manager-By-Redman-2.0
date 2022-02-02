using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM
{
    internal class create : main
    {
        public void Create(string[] words)
        {
            if (words[1] == "file")
            {
                RemoveAt(ref words, 0);
                RemoveAt(ref words, 0);
                string words1 = string.Join(" ", words);
                if (!File.Exists(dir + words1)) File.Create(dir + words1);
                StreamWriter file = new(dir + words1);
                file.Close();
            }
            if (words[1] == "dir")
            {
                RemoveAt(ref words, 0);
                RemoveAt(ref words, 0);
                string words1 = string.Join(" ", words);
                DirectoryInfo dirInfo96 = new(dir + words1);
                if (!dirInfo96.Exists)
                {
                    dirInfo96.Create();
                }
            }
        } 
    }
}
