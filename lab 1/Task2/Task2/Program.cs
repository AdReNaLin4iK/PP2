using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Student
    {
        string name;
        string id;
        int ys;

        public Student (string name, string id)
        {
            this.name = name;
            this.id = id;
            this.ys = 1;
        }

        public string getName()
        {
            return this.name;
        }

        public string getId()
        {
            return this.id;
        }

        public string incYear()
        {
            this.ys++;
        }

        public override string ToString()
        {
            return name + " " + id + " " + ys;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student p = new Student("Abdullakh", "18BD410341");
            Console.WriteLine(p);
            p.incYear();
            Console.WriteLine(p.getId());
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
