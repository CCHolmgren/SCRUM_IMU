using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRUM
{
    class Program
    {
        static People people = new People();
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
            Console.WriteLine("Lägg till person");
            Console.Write("Firstname: ");
            string firstname = Console.ReadLine();
            Console.Write("Lastname: ");
            string lastname = Console.ReadLine();
            Console.Write("Telephone: ");
            string telephonenumber = Console.ReadLine();
            people.addPerson(firstname, lastname, telephonenumber);
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
        /// Change the info of the person associated with id
        /// </summary>
        /// <param name="id"></param>
        static void changeInfo(string id)
        {
            Console.WriteLine("Ändra information");
            if (people.Count != 0)
            {
                Console.Write("Firstname: ");
                people.getPerson(id).firstName = Console.ReadLine();
                Console.Write("Lastname: ");
                people.getPerson(id).lastName = Console.ReadLine();
                Console.Write("Telephonenumber: ");
                people.getPerson(id).telephoneNumber = Console.ReadLine();
            }
        }
        /// <summary>
        /// Removes person from the people dictionary
        /// </summary>
        /// <param name="person"></param>
        static void removePerson(Person person)
        {
            if(people.Count!= 0)
                people.removePerson(person);
        }
        /// <summary>
        /// Removes the person associated with id
        /// </summary>
        /// <param name="id"></param>
        static void removePerson(string id)
        {
            if (people.Count!=0)
                people.removePerson(people.getPerson(id));
        }
        /// <summary>
        /// Prints a brief list of all people that are in the dictionary
        /// </summary>
        static void listAllPeople()
        {
            Console.WriteLine("Alla personer");
            Console.Write(people.ToString());
        }
        static void confirmExit()
        {
            Console.Write("Är du säker att du vill avsluta? (y/n) ");
            if (Console.ReadKey().Key == ConsoleKey.Y)
                exit();
        }
        /// <summary>
        /// Exits the program
        /// </summary>
        static void exit()
        {
            Environment.Exit(0);
        }
        /// <summary>
        /// Gets a choice and returns it
        /// Might implement some form of checking here aswell
        /// </summary>
        static string getChoice(string pretext)
        {
            Console.Write(pretext);
            string choice = Console.ReadLine();
            return choice;
        }
        /// <summary>
        /// Takes person and lists its information
        /// </summary>
        /// <param name="person"></param>
        static void listPerson(Person person)
        {
            Console.WriteLine(person);
        }
        static void listPerson(string id)
        {
            if(people.Count != 0)
                Console.WriteLine(people.getPerson(id));
        }
        static void Main(string[] args)
        {
            string personid;
            string choice;
            string menuText = GetMenu();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Gör ditt val");
                Console.WriteLine(menuText);
                choice = getChoice("Nummer: ");
                switch (choice)
                {
                    case "1":
                        Console.Clear();
                        addPerson();
                        break;
                    case "2":
                        Console.Clear();
                        listAllPeople();
                        personid = getChoice("");
                        Console.Clear();
                        changeInfo(personid);
                        break;
                    case "3":
                        Console.Clear();
                        listAllPeople();
                        personid = getChoice("");
                        Console.Clear();
                        removePerson(personid);
                        break;
                    case "4":
                        Console.WriteLine("case 4");
                        Console.Clear();
                        listAllPeople();
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Clear();
                        listAllPeople();
                        personid = getChoice("");
                        listPerson(personid);
                        break;
                    case "0":
                        Console.Clear();
                        confirmExit();
                        break;
                    default:
                        break;
                }
                //wut();
                //Console.SetCursorPosition(3, 10);
                //wut();
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

            List<Person> personList = people.getPersonList();
            foreach (var person in personList)
            {
                Console.WriteLine(person);
                Console.WriteLine();
            }
        }
    }
}
