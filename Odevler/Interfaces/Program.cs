using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // InterfacesIntro();

            //Demo();

            ICustomerDal[] customerDals = new ICustomerDal[2]
            { 
                new SqlServerCustomerDal(), 
                new OracleCustomerDal() 
            };

            foreach(var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();
        }

        private static void Demo()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
            customerManager.Add(new OracleCustomerDal());
        }

        private static void InterfacesIntro()
        {
            PersonManager personManager = new PersonManager();
            Customer customer = new Customer()
            {
                ID = 1,
                Address = "mgfdk",
                FirstName = "ece",
                LastName = "derin"
            };
            personManager.Add(customer);

            Student student = new Student()
            {
                ID = 2,
                Department = "computer science",
                FirstName = "Ayca",
                LastName = "fssd"
            };
            personManager.Add(student);
        }
    }

    interface IPerson //abstract class yani soyuttur
    {
       int ID { get; set; }
       string FirstName { get; set; }

       string LastName { get; set; }



    }
    class Customer : IPerson //concrete class somut class
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }

    class Student:IPerson
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
