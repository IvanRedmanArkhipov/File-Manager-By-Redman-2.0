using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FM
{
    internal class rename : main
    {
        public void Rename(string[] words)
        {
            string fileOrDir = words[1];

            RemoveAt(ref words, 0);
            RemoveAt(ref words, 0);
            string wordsNew = "";
            for (int i = 0; words[i] != "to"; i++)
            {
                wordsNew += words[i] + " ";
            }
            while (words[0] != "to")
            {
                RemoveAt(ref words, 0);
            }
            RemoveAt(ref words, 0);
            string words1 = string.Join(" ", words);
            
            if (fileOrDir == "file")
            {
                File.Move(main.dir + wordsNew, main.dir + words1);
                File.Delete(main.dir + wordsNew);
            }

            if (fileOrDir == "dir")
            {
                Directory.Move(main.dir + wordsNew, main.dir + words1);
                Directory.Delete(main.dir + wordsNew);
            }
        }
    }
}
