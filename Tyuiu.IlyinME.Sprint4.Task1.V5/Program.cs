using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.IlyinME.Sprint4.Task1.V5.Lib;

namespace Tyuiu.IlyinME.Sprint4.Task1.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Ильин М. Е. | АСОиУБ-23-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы. (ввод с клавиатуры)                           *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Ильин Максим Евгеньевич | АСОиУБ-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан одномерный целочисленный массив на 15 элементов                     *");
            Console.WriteLine("* заполненный значениями с клавиатуры в диапазоне от 5 до 9               *");
            Console.WriteLine("* подсчитать сумму четных элементов массива.                              *");
            Console.WriteLine("* С клавиатуры: 9, 6, 6, 9, 7, 8, 5, 9, 6, 6, 8, 6, 8, 6, 7               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len;
            Console.Write("Введите количество элементов массива: ");
            len = Convert.ToInt32(Console.ReadLine());

            int[] Array = new int[len];
           
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write("Введите значение " + i + " элемента массива: ");
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            for (int i = 0; i <= len - 1; i++)
            {
                Console.Write(Array[i] + "\t");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма четных элементов массива = " + ds.Calculate(Array));
           
            Console.ReadKey();
        }
    }
}
