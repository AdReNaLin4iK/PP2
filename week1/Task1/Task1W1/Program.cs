using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1W1
{
    class Program
    {
        static bool isPrime(int x) 
        {
            if (x == 1) return false; //вызов функции
            for (int i = 2; i <= Math.Sqrt(x); ++i) 
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
            int n = int.Parse(Console.ReadLine()); 

            string ans = ""; //вызываем пустую строку для дальнейшего сохранения чисел

            string s = Console.ReadLine();
            int count = 0; //объявляем счетчик

            string[] arr = s.Split(' '); //разбиваем на отдельные эелементы
            
            for (int i = 0; i < arr.Length; ++i)
            {
                int p = int.Parse(arr[i]); //меняет тип данных(строку принимает в качестве параметра)
                if (isPrime(p)) //вызываем функцию для проверки числа, является ли она простым
                {
                    count++;
                    ans += arr[i] + " "; 
                }  
            }
            Console.WriteLine(count);
            Console.WriteLine(ans);
            Console.ReadKey();
        }
    }
}
