using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //ввод переменного
            string s = Console.ReadLine(); //ввод строки
            string[] arr = s.Split(' '); //создание массива и разбиение на отдельных элементов
            string ans = ""; //вызов пустой строки для дальнейшего сохранения ответа

            for (int i = 0; i < n; ++i)
            {
                ans += arr[i] + " " + arr[i] + " ";
            }

            Console.WriteLine(ans);
            Console.ReadKey();

        }
    }
}
