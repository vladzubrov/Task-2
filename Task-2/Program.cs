using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите минимальную температуру");
            string TempMin = Console.ReadLine();
            Console.WriteLine("Введите максимальную температуру");
            string TempMax = Console.ReadLine();
            double TempMid = (Convert.ToDouble(TempMin) + Convert.ToDouble(TempMax)) / 2;
            Console.WriteLine($"Средняя температурура {Convert.ToString(TempMid)}");
            Console.ReadLine();



        }
    }
}
