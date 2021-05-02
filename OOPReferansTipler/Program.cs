using System;

namespace OOPReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.hafta oopta referans mantığı ödevi
            //int,decimal,enum,char variable types. its mean primitve types
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;
            sayi2 = 100;
            Console.WriteLine(sayi1);


            //array,class,interface vs. referans type dir.
            int[] sayilar1 = new int[] { 1, 2, 3, 4, 5 };
            int[] sayilar2 = new int[] { 99, 98, 67, 44 };

            sayilar1 = sayilar2;
            sayilar2[0] = 890;

            Console.WriteLine(sayilar1[0]);

            Person person1 = new Person();

            Person person2 = new Person();

            person1.FirstName = "engin";
            person2 = person1;
            person1.FirstName = "derin";
            Console.WriteLine(person2.FirstName); //derin yazar



            Customer customer = new Customer();
            customer.FirstName = "ezgi";
            Employee employee = new Employee();
            //employee = customer; // bu hata verir. çünkü referans tipi aynı değildir.

            Person person3 = customer;
            Console.WriteLine(person3.FirstName); //ezgi yazar


            //normalde person3 e customer atanmasına rağmen person3 customerdaki propertilere
            //erişemez person3.creditCardNumber olmaz mesela. bu sebeple boxing işlemi yapılır:
            Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);

            Console.ReadLine();

        }
    }

    class Person
    {

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }



    }

    class Customer : Person
    {

        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person) //polimorfizm yapmış oluyoruz burada.
        {
            Console.WriteLine(person.FirstName);
        }
    }




}
