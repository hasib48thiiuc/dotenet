using DelegatesAndEvents;

namespace Delegate
{

    public class Program
    {
        public delegate void PrintDelegate(object message);

        public static void Calculate(int a, int b, PrintDelegate printer)
        {
            int result = a + b;
            printer(result);
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Test
    {
        public static void Print(object message)
        {
            Console.WriteLine(message);
        }

        public static void Print2(object message)
        {
            Console.WriteLine("---" + message + "---");
        }

        public static void Main(string[] args)
        {
            Program.Calculate(2, 3, Print2);

            Person[] persons = new Person[4];
            persons[0] = new Person { Name = "Jalal Uddin", Age = 40 };
            persons[1] = new Person { Name = "Tareq", Age = 30 };
            persons[2] = new Person { Name = "Tareq", Age = 50 };
            persons[3] = new Person { Name = "Rashed", Age = 90 };


            int CompareValues(Person a, Person b)
            {
                if(a.Name == b.Name)
                {
                    if (a.Age < b.Age)
                        return 1;
                    else if (a.Age > b.Age)
                        return -1;
                    else
                        return 0;
                }
                else
                    return a.Name.CompareTo(b.Name);
            }

            int[] a = new int[] { 1, 5, 3, 9 };
            BubbleSort<Person>.Sort(persons, CompareValues);

            foreach(var item in persons)
                Console.WriteLine($"{item.Name}, {item.Age}");


            PrimeGenerator primeGenerator = new PrimeGenerator();
            //primeGenerator.PrimeGenerationComplete += PrimeGenerator_PrimeGenerationComplete;
            //primeGenerator.PrimeGenerationComplete -= PrimeGenerator_PrimeGenerationComplete;

            Thread thread = new Thread(() => primeGenerator.Generate(100));
            thread.Start();

            var primes = primeGenerator.GetPrimes();
            if (primes != null)
            {
                foreach (var prime in primes)
                    Console.WriteLine(prime);
            }

            Console.ReadLine();
        }

        private static void PrimeGenerator_PrimeGenerationComplete(List<int> primes)
        {
            foreach (var prime in primes)
                Console.WriteLine(prime);
        }
    }
}

