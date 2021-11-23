using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7; //число элементов массива
            int[] array = new int[n]; //инициализация одномерного массива c n элементами
            int i = 0;
            int sum = 0;
             while (i < n)
            {
                Console.WriteLine("Введите элемент массива:");
                //Ввод элементов массива с клавиатуры
                array[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                i++;
            }
            
            for (i = 0; i < n; i++) //вывод массива
            {
                Console.Write("{0} ", array[i]);
            }
            
            for (i = 0; i < n; i++) //суммирование элементов массива
            {
               sum += array[i];
            }
            float srA = (float)sum/n; //подсчет среднего арифметического элементов массива
            Console.WriteLine("Среднеарифметическое элементов массива равно {0:0.00}", srA); // вывод результата
            Console.ReadKey();
        }
    }
}
