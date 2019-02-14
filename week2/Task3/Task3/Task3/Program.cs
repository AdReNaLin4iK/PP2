using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void dfs(DirectoryInfo directory, int num) // dfs Func 
        {
            FileInfo[] files = directory.GetFiles();
            DirectoryInfo[] directories = directory.GetDirectories();

            foreach (FileInfo file in files)
            {
                for (int i = 0; i < num; ++i) Console.Write(" ");
                Console.WriteLine(file.Name);
            }

            foreach (DirectoryInfo d in directories)
            {
                for (int i = 0; i < num; ++i) Console.Write(" ");
                Console.WriteLine(d.Name);
                dfs(d, num + 3);
            }
        }


        static void Main(string[] args)
        {

            string s = Console.ReadLine();
            DirectoryInfo ds = new DirectoryInfo(@s);
            dfs(ds, 0); // start dfs
            Console.ReadKey();
        }
    }
}
