using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] persons = new Person[3]
            {
                new Customer
                {
                    FirstName="engin",
                    ID=1,
                    LastName="AVŞAR"
                },
                new Student
                {
                    FirstName="DENİZ",
                    ID=2,
                    LastName="DFSF"
                },
                new Person
                {
                    FirstName="AYHAN",
                    ID=3,
                    LastName="FDSGSDG"
                }
            };
            
            foreach(var item in persons)
            {
                Console.WriteLine(item.FirstName);
            }

            Console.ReadLine();

        }
    }

    interface IPerson
    {

    }

    class Person:IPerson
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer:Person,IPerson //AYNI ANDA HEM IMPLEMENTE HEM DE INHERITANCE YAPILDI. ONCE KALITIM YAPILAN SINIF SONRA DA IMPLMENETASYON YAPILAN INTERFACE YAZILIR
    {

    }

    class Student:Person,IPerson
    {

    }

}
