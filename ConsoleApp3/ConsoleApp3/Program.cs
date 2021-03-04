using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Random rnd = new Random();
            //initialization of array
            int [,] array = new int [5,5];
            for(int i=0; i< array.GetLength(0); i++)
            {
                for(int j=0; j< array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(0,9); 
                }
            }
            //Вывод диагональных значений в столбик )
            Console.WriteLine("Диагональные элементы в столбик :)");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j) Console.WriteLine(array[i, j]); 
                }
            }
            //Вывод значений матрицы
            Console.WriteLine("Матрица");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                   Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
