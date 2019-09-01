using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateAClass
{
    class Student
    {
        private string name;
        private int age;
        private double finalGrade;
        // Auto-Implemented Property
        public string LastName { get; private set; }

        public Student(string name, string lastName, int age, double finalGrade)
        {
            this.name = name;
            this.LastName = lastName;
            this.age = age;
            this.finalGrade = finalGrade;
        }

        public Student(string name, string lastName, int age) 
            : this(name, lastName, age, 0)
        {
            
        }

        public void SayHello()
        {
            Console.WriteLine($"Hi, my name is {this.name}");
        }

        // Property
        public string Name
        {
            get
            {
                if (this.age >= 18)
                {
                    return this.name;
                }
                else
                {
                    return "This student is too young to display info";
                }
            }

            set
            {
                if (value != "")
                {
                    this.name = value;
                }
            }
        }

        public int Age
        {
            get
            {
                if (this.age >= 18)
                {
                    return this.age;
                }
                else
                {
                    return -1;
                }
            }

            set
            {
                if (value != 0)
                {
                    this.age = value;
                }
            }
        }

        public double FinalGrade
        {
            get
            {
                return this.finalGrade;
            }

            set
            {
                if (value < 65)
                {
                    this.finalGrade= 65;
                }
                else if (value > 100)
                {
                    this.finalGrade = 100;
                }
                else
                {
                    this.finalGrade = value;
                }
            }
        }

    }
}
