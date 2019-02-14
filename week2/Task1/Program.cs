using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\Alpha\Desktop\ABBeration\C#\lab 2\Task1\text  .txt");
            text = text.TrimEnd(); //удаление лишних пробелов
            Console.WriteLine(text);
            char[] txet = text.ToCharArray(); //создание из строки массива чаров

            Array.Reverse(txet);
            Console.WriteLine(txet);

            string s = new string(txet);
            if (s == text)
            Console.WriteLine("YES");

            else Console.WriteLine("NO");
          
            Console.ReadKey();
        }
    }
}
