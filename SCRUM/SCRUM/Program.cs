using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRUM
{
    class Program
    {
        People people = new People();
        /// <summary>
        /// Returns the menu with all options in the beginning of the program
        /// </summary>
        /// <returns></returns>
        static string GetMenu()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("1. Lägg till person.\n");
            sb.Append("2. Ändra uppgifter på person.\n");
            sb.Append("3. Ta bort person.\n");
            sb.Append("4. Lista alla personer.\n");
            sb.Append("5. Information om specifik person.\n");
            sb.Append("0. Avsluta.\n");
            return sb.ToString();
        }
        /// <summary>
        /// Adds a person to the people dictionary
        /// </summary>
        static void addPerson()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Change the info on person
        /// </summary>
        /// <param name="person"></param>
        static void changeInfo(Person person)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Removes person from the people dictionary
        /// </summary>
        /// <param name="person"></param>
        static void removePerson(Person person)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Prints a brief list of all people that are in the dictionary
        /// </summary>
        static void listAllPeople()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Exits the program
        /// </summary>
        static void exit()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Gets a choice and returns it
        /// Might implement some form of checking here aswell
        /// </summary>
        static void getChoice()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Takes person and lists its information
        /// </summary>
        /// <param name="person"></param>
        static void listPerson(Person person)
        {
            throw new NotImplementedException();
        }
        static void Main(string[] args)
        {
            string menuText = GetMenu();
            while (true)
            {
                Console.WriteLine("Gör ditt val");
                Console.WriteLine(menuText);
                Console.Write("Nummer: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        break;
                    case "2":
                        break;
                    case "3":
                        break;
                    case "4":
                        listAllPeople();
                        break;
                    case "0":
                        exit();
                        break;
                    default:
                        break;
                }
                //wut();
                //Console.SetCursorPosition(3, 10);
                //wut();
                Console.Write("Skriv q för att avsluta. ");
            }
        }
        /// <summary>
        /// Trash function that just contains code that I previously tested with
        /// </summary>
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
