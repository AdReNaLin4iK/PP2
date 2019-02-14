using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static bool isPrime(int x) //функция для определения простого числа
        {
            if (x == 1) return false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            StreamReader n = new StreamReader(@"C:\Users\Alpha\Desktop\ABBeration\C#\week2\Task2\input.txt");

            string s = n.ReadLine();
            string[] arr = s.Split(' ');

            n.Close();

            StreamWriter n1 = new StreamWriter("output.txt");

            for (int i=0; i<arr.Count(); i++)
            {
                if (isPrime(int.Parse(arr[i])))
                {
                    n1.Write(arr[i] + " ");
                }
            }

            n1.Close();
        }
    }
}
