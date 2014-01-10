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
            string firstName, lastName, telephoneNumber;
            Console.WriteLine("Ändra information");
            Console.WriteLine("Förnamn: ");
            Console.WriteLine("Efternamn: ");
            Console.WriteLine("Telefonnummer: ");

            Console.SetCursorPosition(9, 1);
            firstName = Console.ReadLine();
            Console.SetCursorPosition(11, 2);
            lastName = Console.ReadLine();
            Console.SetCursorPosition(15, 3);
            telephoneNumber = Console.ReadLine();

            /*Console.WriteLine("Lägg till person");
            Console.Write("Förnamn: ");
            string firstname = Console.ReadLine();
            Console.Write("Efternamn: ");
            string lastname = Console.ReadLine();
            Console.Write("Telefonnummer: ");
            string telephonenumber = Console.ReadLine();*/

            people.addPerson(firstName, lastName, telephoneNumber);
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
            if (people.Count != 0)
            {
                Person person = people.getPerson(id);
                Console.WriteLine("Ändra information (tidigare ifyllda värden visas i grön text)");
                Console.Write("Förnamn: ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(String.Format("{0}", person.firstName) + "\n");
                Console.ResetColor();

                Console.Write("Efternamn: ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(String.Format("{0}", person.lastName) + "\n");
                Console.ResetColor();

                Console.Write("Telefonnummer: ");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write(String.Format("{0}", person.telephoneNumber)+"\n");
                Console.ResetColor();

                /*Console.WriteLine("Förnamn: " + String.Format("({0}) ", person.firstName));
                Console.WriteLine("Efternamn: " + String.Format("({0}) ", person.firstName));
                Console.WriteLine("Telefonnummer: " + String.Format("({0}) ", person.firstName));
                */
                Console.SetCursorPosition(9, 1);
                person.firstName = Console.ReadLine();
                Console.SetCursorPosition(11, 2);
                person.lastName = Console.ReadLine();
                Console.SetCursorPosition(15, 3);
                person.telephoneNumber = Console.ReadLine();

                /*Console.Write("Firstname: ");
                people.getPerson(id).firstName = Console.ReadLine();
                Console.Write("Lastname: ");
                people.getPerson(id).lastName = Console.ReadLine();
                Console.Write("Telephonenumber: ");
                people.getPerson(id).telephoneNumber = Console.ReadLine();*/
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
                        personid = getChoice("Nummer: ");
                        Console.Clear();
                        changeInfo(personid);
                        break;
                    case "3":
                        Console.Clear();
                        listAllPeople();
                        personid = getChoice("Nummer: ");
                        Console.Clear();
                        removePerson(personid);
                        break;
                    case "4":
                        Console.Clear();
                        listAllPeople();
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.Clear();
                        listAllPeople();
                        personid = getChoice("Nummer: ");
                        Console.Clear();
                        listPerson(personid);
                        getChoice("Tryck enter när du är klar.");
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
