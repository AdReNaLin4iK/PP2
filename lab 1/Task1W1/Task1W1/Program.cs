using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1W1
{
    class Program
    {
        static bool isPrime(int x) //создаем функцию для упрощения решения
        {
            if (x == 1) return false; //единица не является простым числом
            for (int i = 2; i <= Math.Sqrt(x); ++i) //проверка числа, является ли она простым
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
            int n; //объявляем переменную
            n = int.Parse(Console.ReadLine()); //ввод переменной

            string ans = ""; //вызываем пустую строку для дальнейшего сохранения чисел

            string s; //вызываем строчную переменную
            int cnt = 0; //объявляем счетчик
            s = Console.ReadLine(); //ввод строки 

            string[] arr = s.Split(' '); //разбиваем на отдельные эелементы
            
            for (int i = 0; i < arr.Length; ++i)
            {
                int p = int.Parse(arr[i]); //меняет тип данных(строку принимает в качестве параметра)
                if (isPrime(p)) //вызываем функцию для проверки числа, является ли она простым
                {
                    cnt++;
                    ans += arr[i] + " "; 
                }  
            }
            Console.WriteLine(cnt);
            Console.WriteLine(ans);
            Console.ReadKey();
        }
    }
}
