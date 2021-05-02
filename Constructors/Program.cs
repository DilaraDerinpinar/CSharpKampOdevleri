using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { City = "istanbul", FirstName = "ece", ID = 1, LastName = "derin" }; //burada Customer classı içindeki propertilere değer atanıyor bunlar parametre değildir.

            Customer customer2 = new Customer(2,"ali","atay","ankara"); //parametreli constructora parametre yollanıyor burada.

            Customer customer3 = new Customer();
            customer3.City = "izmir";//bu da customer1 gibidir.

            Console.WriteLine(customer2.City);
        }

       
    }

    class Customer
    {
        //default constructor:
        public Customer()
        {
            Console.WriteLine("yapıcı blok çalıştı");
        }

        //parametreli constructor
        public Customer(int ID,string FirstName,string LastName,string City)
        {
            this.LastName = LastName;
            this.ID = ID;
            this.FirstName = FirstName;
            this.City = City;
        }
        
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
