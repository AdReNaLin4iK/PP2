﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Alpha\Desktop\ABBeration\C#\week2\Task4\delete.txt";

            string path1 = @"C:\Users\Alpha\Desktop\ABBeration\C#\week2\Task4\Task4";

            DirectoryInfo dirInfo = new DirectoryInfo(path1);

            FileInfo fi = new FileInfo(path);

            if (fi.Exists && dirInfo.Exists)
            {
                fi.CopyTo(path1 + @"\Copied.txt", true);

                fi.Delete();
            }

            else Console.WriteLine("path or path2 not found");
        }
    }
}
