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
        private int ageOfAccess;

        public int AgeOfAccess
        {
            set
            {
                if(value < 18)
                {
                    Console.WriteLine("You must have 18 or more years old");
                }
                else
                {
                    ageOfAccess = value;
                }
            }
            get
            {
                return ageOfAccess;
            }
        }


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

            Account.MinSum = 560;
            /*Console.Write("Write amount, which you want to deposit: ");
            decimal sum = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Write on which period you want to deposit: ");
            int period = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Amount which you'll get after {period} mounths is {Account.GetSum(sum, 10, period)}");*/

            Counter c1 = new Counter { Value = 23 };
            Counter c2 = new Counter { Value = 45 };
            bool result = c1 > c2;
            Console.WriteLine(result);
            Counter c3 = c1 + c2;
            Console.WriteLine(c3.Value);

            Counter counter = new Counter { Value = 10 };
            if(counter)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }

            Company company = new Company {};
            string companyName = company?.Name ?? "doesn't set";
            Console.WriteLine("Name of company: " + companyName);

            Console.ReadLine();
        }
    }

    class Account
    {
        public Account(decimal sum, decimal rate)
        {
            if (sum < minSum) throw new Exception("Unacceptable summary");
            Sum = sum;
            Rate = rate;
        }
        private static decimal minSum = 100;
        public static decimal MinSum
        {
            get { return minSum; }
            set { if (value > 0) minSum = value; }
        }
        public decimal Sum { get; private set; }
        public decimal Rate { get; private set; }

        public static decimal GetSum(decimal sum, decimal rate, int period)
        {
            decimal result = sum;
            for (int i = 1; i <= period; i++)
                result = result + result * rate / 100;
            return result;
        }
    }
    class Counter
    {
        public int Value { get; set; }
        public static Counter operator +(Counter c1, Counter c2)
        {
            return new Counter { Value = c1.Value + c2.Value };
        }
        public static bool operator >(Counter c1, Counter c2)
        {
            return c1.Value > c2.Value;
        }
        public static bool operator <(Counter c1, Counter c2)
        {
            return c1.Value < c2.Value;
        }
        public static bool operator true(Counter c1)
        {
            return c1.Value != 0;
        }
        public static bool operator false(Counter c1)
        {
            return c1.Value == 0;
        }
    }
    class Company
    {
        public string Name { get; set; }
    }
}
