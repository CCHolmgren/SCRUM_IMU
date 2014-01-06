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
            do
            {
                wut();
                Console.WriteLine(String.Format("Yes\r{0,-10}","no"));
            } while (Console.ReadKey().Key != ConsoleKey.Q);
            Console.ReadLine();
        }
        static void wut()
        {
            Person chris = new Person("Chris", "Holm", "0738234460");
            People people = new People();
            people.addPerson(chris);
            Person test = people.getPerson(chris);
            Console.WriteLine(test);
            Console.WriteLine();

            Person towe = new Person("Towe", "1", "2");
            people.addPerson(towe);
            test = people.getPerson(towe);
            Console.WriteLine(test);
            Console.WriteLine();

            Person editPersonZero = people.getPerson(0);
            editPersonZero.firstName = "Test";
            editPersonZero.lastName = "TestAgain";

            List<Person> personList = people.getPersonAll();
            foreach (var person in personList)
            {
                Console.WriteLine(person);
                Console.WriteLine();
            }
        }
    }
}
