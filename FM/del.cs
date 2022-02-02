using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM
{
    internal class del : main
    {
        public static void Delete(string[] words)
        {
            if (words[1] == "file") //удаление файла
            {
                RemoveAt(ref words, 0);
                RemoveAt(ref words, 0);

                string words1 = string.Join(" ", words);

                string dirToDel = dir + "/" + words1;

                FileInfo fileDel = new(dirToDel);
                if (fileDel.Exists)
                {
                    fileDel.Delete();
                }
            }
            else if (words[1] == "dir") //удаление папки
            {
                RemoveAt(ref words, 0);
                RemoveAt(ref words, 0);

                string words1 = string.Join(" ", words);

                string dirToDel = dir + "/" + words1;
                Directory.Delete(dirToDel, true);
            }
        }
    }
}
