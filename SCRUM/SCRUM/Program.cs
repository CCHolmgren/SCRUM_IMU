using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRUM
{
    class Program
    {
        static void Main(string[] args)
        {
            Person chris = new Person("Chris","Holm","0738234460");
            People people = new People();
            people.addPerson(chris);
            Person test = people.getPerson(chris);
            Console.WriteLine(test);
            Console.WriteLine();

            Person towe = new Person("Towe", "1", "2");
            people.addPerson(towe);
            test = people.getPerson(towe);
            //Console.WriteLine(people.getId(towe));
            Console.WriteLine(test);
            Console.WriteLine();

            List<Person> personList = people.getPersonAll();
            foreach (var person in personList)
            {
                Console.WriteLine(person);
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
