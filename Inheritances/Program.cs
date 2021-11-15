using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritances //Miras
{
    class Program
    {
        static void Main(string[] args)
        {
            Players ply = new Players();
            Coach coach = new Coach();
            Person person = new Person();
            //her bir class ayrı ayrı implemente edilebilir.
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
    class Person2 
    {
        //her bir class bir yerden miras alır
        //interfaceler birden fazla olabilir ancak miras işlemi bir kere tanımlanır.
    }

    class Players:Person
    {
        public string Position { get; set; }
    }

    class Coach:Person
    {
        public string CoachPosition { get; set; }
    }
}
