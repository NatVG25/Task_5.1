using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._1_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[7]; 
            Console.WriteLine("Введите первое число:");
            array[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            array[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите третье число:");
            array[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите четвертое число:");
            array[3] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите пятое число:");
            array[4] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите шестое число:");
            array[5] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите седьмое число:");
            array[6] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            for (int i = 0; i < 7; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.ReadKey();
        }
    }
}
