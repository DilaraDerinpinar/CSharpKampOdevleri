using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {

                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach(var item in workers)
            {
                item.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker()
            };

            foreach(var item2 in eats)
            {
                item2.Eat();
            }


            ISalary[] salaries = new ISalary[2]
            {
                new Manager(),
                new Worker()
            };

            foreach(var item3 in salaries)
            {
                item3.GetSalary();
            }




        }
    }

    

    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker,IEat,ISalary
    {
        public void Eat()
        {
            Console.WriteLine("manager eats pizza");
        }

        public void GetSalary()
        {
            Console.WriteLine("managers salary is 32000");
        }

        public void Work()
        {
            Console.WriteLine($"managers work is management ");
        }
    }

    class Worker : IWorker,IEat,ISalary
    {
        public void Eat()
        {
            Console.WriteLine("a");
        }

        public void GetSalary()
        {
            Console.WriteLine("b");
        }

        public void Work()
        {
            Console.WriteLine("c");
        }
    }

    class Robot : IWorker
    {
        

        public void Work()
        {
            Console.WriteLine("x");
        }
    }
}
