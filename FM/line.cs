using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FM
{
    internal class line
    {
        public static void print(int num)
        {
            for (int i = 0; i < Console.BufferWidth; i++)
            {
                Console.SetCursorPosition(i, num);
                Console.WriteLine('-');
            }
        }
    }
}
