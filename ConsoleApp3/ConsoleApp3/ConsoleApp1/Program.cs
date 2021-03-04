using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] Contacts = new string [5,2];     //Инициализация массива
            byte counter = 0;                          //Счетчик контактов
            
            while (true)
            {
                int menu;                              //Интерфейс
                
                Console.WriteLine("Чтобы добавить контакт, нажмите 1\nЧтобы открыть справочник, нажмите 2");
                menu = Convert.ToInt32( Console.ReadLine());
                if (menu==1) //Добавление нового контакта
                {
                    while (counter<Contacts.GetLength(0))
                    {
                        Console.WriteLine("Введите имя");
                        Contacts[counter, 0] = Console.ReadLine();
                        Console.WriteLine("Введите номер телефона");
                        Contacts[counter, 1] = Console.ReadLine();
                        Console.WriteLine($"Записан контакт {Contacts[counter,0]} {Contacts[counter, 1]}");
                        counter++;
                        break;
                    }
                    if (counter == 5) { Console.WriteLine("Телефонный справочник заполнен"); }
                }
                if(menu==2)  //Поиск контакта
                {
                    string search;
                    Console.WriteLine("Введите имя человека, с которым Вы бы хотели установить контакт");
                    search = Console.ReadLine();
                    bool absent = true;
                    for (int i=0;i< Contacts.GetLength(0); i++)
                    {
                        if (search == Contacts[i, 0]) { Console.WriteLine($"Есть контакт {Contacts [i,1]}"); absent = false; break; }

                    }
                    if (absent) Console.WriteLine("Нет контакта");

                }
            }
        }
    }
}
