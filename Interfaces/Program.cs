using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //interfaceler hiçbir zaman new keywordü ile kullanılamazlar.
            // IPerson iper = new IPerson(); soyut olduğu için işlem yapılamaz
            //ancak ıperson interface inden türettiğimiz sınıflar new lenebilir.
            InterfacesBegin();

            //ICustomerDal[] cd = new ICustomerDal[2]
            //{
            //     new UseSqlDal(),
            //    new UseOracle()

            //};
            //foreach (var customerDal in cd)
            //{
            //    customerDal.Add();
            //};

            //CustomerManager cm = new CustomerManager();
            //{
            //    cm.Add(new UseSqlDal());
            //    cm.Add(new UseOracle());
            //}
            Console.ReadLine();

        }

        private static void InterfacesBegin()
        {
            IPerson person = new Customer();
            IPerson person1 = new Student();//ıpersondan ürettiğimiz için izin verir


            Customer customer = new Customer
            {
                id = 1,
                Name = "Onur",
                Lastname = "Ağıcı",
                Adress = "Essengles"
            };
            Student student = new Student
            {
                id = 2,
                Name = "Selin",
                Lastname = "Ağıcı",
                StudentNo = "445"
            };

            PersonManager pm = new PersonManager();
            pm.Add(customer);
        }
    }

    interface IPerson //soyut nesne
    {
        //Temel(base) nesne  oluşturup diğer nesneleri ondan implemente etmektir
        //soyut nesneler tek başlarına anlam ifade etmezler ve somut nesnelere ihtiyaç duyarlar.
        int id { get; set; }
        string Name { get; set; }
        string Lastname { get; set; }
    }

    class Customer : IPerson//somut nesne
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }

        public string Adress { get; set; }
    }

    class Student : IPerson
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string StudentNo { get; set; }
    }

    class PersonManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name);
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }
    }
}
