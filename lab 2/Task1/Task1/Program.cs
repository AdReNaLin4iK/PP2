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
            string text = "abba";
            File.WriteAllLines("C:\Users\Alpha\Desktop\ABBeration\C#\lab 2\Task.txt", text);

            string text = File.ReadAllText(@"C:\Users\Alpha\Desktop\ABBeration\C#\lab 2\Task.txt");
            System.Console.WriteLine(" ", text);

        }
    }
}
