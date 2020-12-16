using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        
        static void Main()
        {
            Console.WriteLine("Введите месяц");
            string a = Console.ReadLine();
            Console.WriteLine("Введите температуру");
            string b = Console.ReadLine();
            int Month = Convert.ToInt32(a);
            switch (Month)
            {
                case 11:
                case 0:
                case 1:
                    Console.WriteLine(Convert.ToBoolean(Convert.ToInt32(b)>0)? "Дождливая зима" : "Зима");
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Весна");
                    break;
                case 5:
                case 6:
                case 7:
                    Console.WriteLine("Лето");
                    break;
                case 8:
                case 9:
                case 10:
                    Console.WriteLine("Осень");
                    break;
                default:
                    Console.WriteLine("Укажите значение от 0 до 11");
                    break;
            }
            Console.ReadLine();


        }
    }
}
