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
        int god;

        public Student (string name, string id)
        {
            this.name = name; //предоставление доступа к экземпляру класса
            this.id = id; 
            this.god = 1;
        }

        public string printName()
        {
            return this.name;
        }

        public string printId()
        {
            return this.id;
        }

        public void incGod()
        {
            this.god++;
        }

        public override string ToString()
        {
            return name + " " + id + " " + god;
        } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student p = new Student("Erlan", "19BD001122");
            Console.WriteLine(p);
            p.incGod();
            Console.WriteLine(p);
            Console.ReadKey();
        }
    }
}
