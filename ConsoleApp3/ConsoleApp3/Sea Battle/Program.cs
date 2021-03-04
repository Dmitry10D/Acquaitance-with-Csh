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
            
            //U+2592 0xB1 море
            //U+2588 0xDB палуба
            Random rnd = new Random();
            //Console.OutputEncoding = Encoding.UTF8; Какой-то волшебный код, предложенный Генадием Курбесовым, для превращения кода символа в символ
            //var ch = (char)0x2592;
            for (int i = 0; i < thesea.GetLength(0); i++)//заполняем массив символами моря
            {
                for(int j = 0; j < thesea.GetLength(1); j++)
                {
                    thesea[i, j] = '\u2592';
                }
            }
            //четырехпалубник (генерируем)
            int x4 = rnd.Next(0, 6);
            int y4 = rnd.Next(0, 6);
            int orient = rnd.Next(0, 2);
            if (orient == 0) 
            {
                for (int i=y4;i<y4+4;i++)
                {
                    thesea[x4,i]= '\u2588';
                }
            
            }
            if (orient==1)
            {
                for (int i = x4; i < x4 + 4; i++)
                {
                    thesea[i, y4] = '\u2588';
                }
            }
            //трехпалубник (генерируем) Их тут должно быть два. А еще должно быть описано правило несоседства. Все это я не успел запрограммировать
            //т.к. слишком долго разбирался с методами ToString, Convert.ToChar, GetChars, GetString. Ни один из них не подошел для кодирования символов Unicode
            //а задание это, как я понял, на работу с классом Encoding. 
            //Для кораблей проще создать класс и описать в нем правила генерации. Наверное, я это сделаю. К сроку сдачи это не успелось.
            int x3 = rnd.Next(0, 6);
            int y3 = rnd.Next(0, 6);
            int orient3_1 = rnd.Next(0, 2);
            if (orient3_1 == 0)
            {
                for (int i = y3; i < y3 + 3; i++)
                {
                    thesea[x3, i] = '\u2588';
                }

            }
            if (orient3_1 == 1)
            {
                for (int i = x3; i < x3 + 3; i++)
                {
                    thesea[i, y3] = '\u2588';
                }
            }
            for (int i = 0; i < thesea.GetLength(0); i++)
            {
                for (int j = 0; j < thesea.GetLength(1); j++)
                {
                    Console.Write(thesea[i, j]);
                    Console.Write(thesea[i, j]);
                }
                Console.WriteLine();
            }
            
        }
    }
}
