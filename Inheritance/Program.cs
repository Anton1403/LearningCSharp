using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("Anton Bialenik", "SPG");
            Person person = emp1;
            Console.WriteLine(person.Name);
            Person person2 = new Client("Kirill Nekrevich", "SpaceBank");
            Console.WriteLine(person2.Name);
            Employee emp2 = (Employee)person;
            Console.WriteLine(emp2.Name + emp2.Company);
            object obj = new Employee("Alexey Apa", "Renault");
            ((Person)obj).Display();
            Person person3 = new Person("Vladislav Gu");
            if(person3 is Employee)
            {
                Employee emp = (Employee)person3;
                Console.WriteLine(emp.Company);
            }
            else
            {
                Console.WriteLine("Casting error");
            }
            
            Console.ReadLine();
        }
    }
    class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public void Display()
        {
            Console.WriteLine($"Person {Name}");
        }
    }

    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }
    }
    class Client : Person
    {
        public string Bank { get; set; }
        public Client(string name, string bank) : base(name)
        {
            Bank = bank;
        }
    }
}
