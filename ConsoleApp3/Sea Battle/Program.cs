using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sea_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] thesea = new char[10,10];
            //char[] seablock = {0xB1};
            //U+2592 0xB1 море
            //U+2588 0xDB палуба
            
            Console.OutputEncoding = Encoding.UTF8;
            var ch = (char)0x2592;
            for (int i = 0; i < thesea.GetLength(0); i++)
            {
                for(int j = 0; j < thesea.GetLength(1); j++)
                {
                    thesea[i, j] = ch;
                    //thesea[i, j] = Encoding.ASCII.GetChars(01);
                }
            }
            for (int i = 0; i < thesea.GetLength(0); i++)
            {
                for (int j = 0; j < thesea.GetLength(1); j++)
                {
                    Console.WriteLine(thesea[i, j]);
                }
            }
        }
    }
}
