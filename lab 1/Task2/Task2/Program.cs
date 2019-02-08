using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static bool isPrime(int x)
        {
            if (x == 1) return false;
            for (int i=2; i<= Math.Sqrt(x); i++)
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
            int n;
            n = int.Parse(Console.ReadLine());

            string ans = "";

            string s;
            s = Console.ReadLine();
            int count = 0;

            string[] arr = s.Split(' ');
            
            for (int i=0; i <arr.Length; i++)
            {
                int p = int.Parse(arr[i]);
                if (isPrime(p))
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
