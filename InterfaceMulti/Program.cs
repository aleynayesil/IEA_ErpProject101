using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMulti
{
    class Program
    {
        static void Main(string[] args)
        {
            //bir classta birden fazla interface kullanılabilir
            //solid prensiblerinden 4.sü olan interface segragation prensibini kullandık.
            //single responsibiliy:sınıflarımızın iyi tanımlanmış tek bir sorumluluğu olmalıdır.
            //open/closed : sınıfların değişikliğe kapalı ancak yeni davranışların eklenmesine açık olmalı
            //liskov substitution : kodumuzda herhangi bir değişiklik yapmaya gerek kalmadan türetilmiş sınıfların (sub classların) türedikleri ata sınıfın(base class) yerine kullanabilmeliyiz.
            //interface segregation : genel kullanım amaçlı tek bşr kontrat yerine daha özelleşmiş birden çok kontrat oluşturmayı tercih etmeliyiz.
            //dependency inversion : katmanlı mimariler de üst seviye modüller alt seviyedeki modüllere doğrudan bağımlı olmamalıdır

        }
    }
    interface IWorker
    {
        void Work();
      
    }
    interface IEat{
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
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void GetSalary()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }
}
