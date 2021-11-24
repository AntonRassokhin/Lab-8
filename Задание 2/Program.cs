using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Автоматизация BIM (ИТМО)\1_C#\Домашки\10numbers.txt";
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            Random random = new Random();
            int[] arrayWrite = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arrayWrite[i] = random.Next(0, 10);
            }
            for (int i = 0; i < 10; i++)
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.WriteLine(arrayWrite[i]);
                }
            }

            string[] arrayRead = File.ReadAllLines(path);
            int sum = 0;
            foreach (string n in arrayRead)
            {
                Console.WriteLine(n);
                sum += Convert.ToInt32(n);
            }               
            
            Console.WriteLine("Сумма чисел в файле ={0}", sum);
            Console.ReadKey();
        }
    }
}
