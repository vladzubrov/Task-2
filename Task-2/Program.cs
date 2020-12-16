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
            Console.WriteLine("Введите номер месяца");
            string numMonth_str = Console.ReadLine();
            int numMonth_int = Convert.ToInt32(numMonth_str);
            string MonthTitle = "";
            switch (numMonth_int)
            {
                case 0:
                    MonthTitle = "Январь";
                    break;
                case 1:
                    MonthTitle = "Февраль";
                    break;
                case 2:
                    MonthTitle = "Март";
                    break;
                case 3:
                    MonthTitle = "Апрель";
                    break;
                case 4:
                    MonthTitle = "Май";
                    break;
                case 5:
                    MonthTitle = "Июнь";
                    break;
                case 6:
                    MonthTitle = "Июль";
                    break;
                case 7:
                    MonthTitle = "Август";
                    break;
                case 8:
                    MonthTitle = "Сентябрь";
                    break;
                case 9:
                    MonthTitle = "Октябрь";
                    break;
                case 10:
                    MonthTitle = "Ноябрь";
                    break;
                case 11:
                    MonthTitle = "Декабрь";
                    break;
                default:
                    Console.WriteLine("Укажите значение от 0 до 11");
                    break;

            }
            Console.WriteLine(MonthTitle);



            Console.ReadLine();
        }
    }
}
