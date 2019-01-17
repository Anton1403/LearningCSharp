using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Person
    {
        public string name;
        public int age;
        public Person() : this("Not found")
        {

        }
        public Person(string name) : this(name, 18)
        {

        }
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }


        public void GetInfo()
        {
            Console.WriteLine($"Name: {name}, age: {age}");
        }
    }

    struct User
    {
        public string name;
        public int age;

        public User(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person tom = new Person();
            Person bob = new Person("Bob");
            Person jack = new Person("Jack", 31);

            jack.GetInfo();
            bob.GetInfo();
            tom.GetInfo();


            User anton = new User("Anton", 20);
            anton.DisplayInfo();

            User kirill = new User();
            kirill.DisplayInfo();

            Console.ReadLine();
        }
    }
}
