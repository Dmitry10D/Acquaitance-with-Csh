using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rndnum = new Random();
            double prihod = rndnum.Next(0, 100) + rndnum.NextDouble();
            string CNO = "ЕНВД";
            string user = "ООО Домтехсервис";
            string adress = "Москва г. Кирпичная ул. дом 43";
            string saler = "Даниил Монин";
            int INN = 1234567890;

            Console.WriteLine($"Чек коррекции \nприход  {prihod}\nИтог = {prihod}\n" +
                $"Оплата наличными {rndnum.Next(100, 1000)}\nСНО {CNO}\nПользователь {user}\nАдрес расчетов {adress}\nКассир {saler}\n" +
                $"Дата Время {DateTime.Now}\nИНН {INN}\nСпассибо за покупку!\nлюбые совпадения случайны");
        }
    }
}
