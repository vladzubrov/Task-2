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
            Console.WriteLine("Введите число");
            string a_str = Console.ReadLine();
            Console.WriteLine(Convert.ToBoolean(Convert.ToInt32(a_str)%2==0)?"Четное":"Не четное");
            Console.ReadLine();


        }
    }
}
