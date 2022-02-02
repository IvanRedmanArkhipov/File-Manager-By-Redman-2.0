using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM
{
    internal class copyPaste : main
    {
        static int copyFile = 2;
        static string pasteDir = "";
        static string copyDir = "";

        public void Copy(string [] words)
        {
            if (words[1] == "file")
            {
                copyFile = 1;
            }
            if (words[1] == "dir")
            {
                copyFile = 0;
            }
            main.RemoveAt(ref words, 0);
            main.RemoveAt(ref words, 0);
            pasteDir = string.Join(" ", words);
            copyDir = dir + pasteDir;
        }

        public void Paste()
        {
            if (copyFile == 1)
            {
                FileInfo fileInf = new(copyDir);
                fileInf.CopyTo(dir + pasteDir);
            }
            if (copyFile == 0)
            {
                CopyDir(copyDir, dir + pasteDir + @"\");
            }
        }

        static void CopyDir(string FromDir, string ToDir)
        {
            Directory.CreateDirectory(ToDir);
            foreach (string s1 in Directory.GetFiles(FromDir))
            {
                string s2 = ToDir + @"\" + Path.GetFileName(s1);
                File.Copy(s1, s2);
            }
            foreach (string s in Directory.GetDirectories(FromDir))
            {
                CopyDir(s, ToDir + @"\" + Path.GetFileName(s));
            }
        }
    }
}
