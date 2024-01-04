using System;

namespace DesignPatterns_For_CSharp.Structural_Patterns.Composite
{
    public class Employee : Composite
    {
        public Employee(bool isBaseEmployee) : base(isBaseEmployee) { }

        public string name;
        public string sex;
        public int salary;
        public int age;
        public void SetMessage(string name, string sex, int age, int salary)
        {
            this.name = name;
            this.sex = sex;
            this.salary = salary;
            this.age = age;
        }
        protected override void DoWork()
        {
            Console.Write($"[Name:{name}][Age:{age}][Sex:{sex}]:Doing some work, and {(sex == "man" ? "his" : "her")} salary is {salary}.");
            if (!isLeaf)
                Console.WriteLine($"who has {subComposites.Count} Employees work under.");
            else Console.WriteLine();
        }
    }
}