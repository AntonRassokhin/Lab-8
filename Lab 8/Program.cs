using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\Автоматизация BIM (ИТМО)\1_C#\Домашки";
            string[] dirs = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);
            foreach (string d in dirs)
            {
                Console.WriteLine(d);
            }
            Console.ReadKey();
        }
    }
}
