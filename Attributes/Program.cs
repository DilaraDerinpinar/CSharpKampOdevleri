using System;

namespace Attributes
{
    class Program
    {
        //11.GÜN ÖDEV 3 ATTRIBUTES VE ATTRIBUTE TARGETS, ALLOWMULTIPLE GİRİŞ
        static void Main(string[] args)
        {
            Customer customer = new Customer
            {
                Id = 1,
                LastName = "derin",
                Age = 34
            };

            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer); //burada tabi hata aldık üzerine geldiğimizde attribute içine yazdıgımız bilgilendirici mesaj görünecektir.
            Console.ReadLine();
        }
    }

    [ToTable("Customers")] //veritabanında kontrol edicez böyle bir tablo varsa customer classını ekleyeceğiz. classlara da attribute konabilir ve parametre yollanabilir attributelara.
    class Customer
    {
        public int Id { get; set; }
        [RequiredProperty] //first name alanı zorunlu olsun dedik.
        [RequiredProperty]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    class CustomerDal
    {
        [Obsolete("Dont use add,instead use AddNew method")] //eski demektir. bu metodun artık kullanılmaması gerektiğini ifade etmektedir.
        public void Add(Customer customer)
        {
            Console.WriteLine("{0},{1},{2},{3}", customer.Id, customer.FirstName, customer.LastName, customer.Age);
        }

        public void AddNew(Customer customer) //diyelim ki ben artık ekleme yapmak için bu metodu kullanmak istiyorum ve yukardaki add metodunun eski oldugunu söylemeye çalışıcam.
        {
            Console.WriteLine("{0},{1},{2},{3}", customer.Id, customer.FirstName, customer.LastName, customer.Age);

        }
    }

    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field,AllowMultiple =true)] // requiredpropertyattribute unu property ve fieldlara uygulayabilirsin anlamında kısıtladık.
    //allowMultiple ın anlamı bir property üzerinde birden fazla attribute tanımlanabilir miyi ifade eder. true ise onaylanır.
    class RequiredPropertyAttribute : Attribute
    {

    }

    [AttributeUsage(AttributeTargets.Class)]
    class ToTableAttribute : Attribute
    {
        private string _tableName;
        public ToTableAttribute(string tableName)
        {
            _tableName = tableName;
        }
    }

}
