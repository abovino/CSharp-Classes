using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Angelo", "Bovino", 29, 99.99);
            s1.SayHello();

            Console.WriteLine(s1.Name);

            Console.ReadLine();
        }
    }
}
