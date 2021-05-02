using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }

    class Customer
    {
        private string _lastName;
        public int ID { get; set; }
        public string FullName { get; set; }
        public string LastName
        {

            get { return "mrs" + _lastName; }
            set { _lastName = value; }


        }
    }

}
