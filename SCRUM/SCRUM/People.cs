using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRUM
{
    /// <summary>
    /// Represents a collection of Persons
    /// As of this time this assumes that you are certain that person is already in the dictionary
    /// Will break otherwise
    /// </summary>
    public class People
    {
        private Dictionary<string, Person> people = new Dictionary<string, Person>();
        private int __maxpersonindex = 0;
        private string maxPersonIndex
        {
            get
            {
                //The return is a string, but we want to increment it afterwards
                //This way we get what __maxpersonindex was before the increment and then increment it after
                return (__maxpersonindex++).ToString();
            }
        }
        /// <summary>
        /// Given id returns a specific person associated with that id
        /// Will throw KeyNotFoundError if you try to get a person not in the dictionary
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Person with the given id</returns>
        public Tuple<bool, Person> getPerson(int id)
        {
            return getPerson(id.ToString());
            //return people.Single(p => p.Key == id.ToString()).Value;
        }
        /// <summary>
        /// Given id returns a specific person associated with that id
        /// Will throw KeyNotFoundError if you try to get a person not in the dictionary
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Tuple with a bool and a Person</returns>
        public Tuple<bool, Person> getPerson(string id)
        {
            if (existsPerson(id))
                return new Tuple<bool, Person>(true, people[id]);
            else
                return new Tuple<bool, Person>(false, new Person());
        }
        /// <summary>
        /// Gives you the number of people in the dictionary
        /// </summary>
        /// <returns>Amount of people in the dictionary</returns>
        public int Count
        {
            get
            {
                return people.Count;
            }
        }
        /// <summary>
        /// Given a specific person return that person
        /// Should only be used for testing since its useless
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        [Obsolete("This method is obsolete and should only be used for testing.")]
        public Person getPerson(Person person)
        {
            return people.Single(p => p.Key == person.id).Value;
        }
        /// <summary>
        /// Given a specific person return that persons id
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        [Obsolete("This method is obsolete and should only be used for testing. Person already has an id if it's added to the dictionary.")]
        public string getId(Person person)
        {
            return people.Single(p => p.Value == person).Key;
        }
        /// <summary>
        /// Adds person to the people collection
        /// </summary>
        /// <param name="person"></param>
        /// <returns>Person added</returns>
        public Person addPerson(Person person)
        {
            string index = maxPersonIndex;
            person.id = index;
            people.Add(index, person);
            return person;
        }
        /// <summary>
        /// Adds a person given the firstName lastName and telephoneNumber
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="telephoneNumber"></param>
        /// <returns>Person added</returns>
        public Person addPerson(string firstName, string lastName, string telephoneNumber)
        {
            //DRY
            Person person = new Person(firstName, lastName, telephoneNumber);
            return this.addPerson(person);
            /*string index = maxPersonIndex;
            person.id = index;
            people.Add(index, person);*/
            //return person;
        }
        /// <summary>
        /// Removes person from the dictionary
        /// It's totally safe to remove something that isn't in the dictionary in the first place
        /// </summary>
        /// <param name="person">Person to remove</param>
        public void removePerson(Person person)
        {
            people.Remove(person.id);
        }
        /// <summary>
        /// Checks if person is in the dictionary or not
        /// </summary>
        /// <param name="person"></param>
        /// <returns>true if people contains specific person</returns>
        public bool existsPerson(Person person)
        {
            return people.ContainsValue(person);
          //  return people.Any(p => p.Value == person);
        }
        /// <summary>
        /// Checks if id is in the dictinary or not
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool existsPerson(string id)
        {
            return people.ContainsKey(id);
        }
        /// <summary>
        /// Returns all persons
        /// The ordering will not be guaranteed, so do not rely on it
        /// </summary>
        /// <returns>All persons added</returns>
        public List<Person> getPersonList()
        {
            return people.Values.ToList();
        }
        /// <summary>
        /// Overrides object.ToString() so we get 
        /// the whole dictionary instead of some useless info
        /// </summary>
        /// <returns>Person nummer +person.id: + person.firstName\n ad finitum</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var x in people)
            {
                sb.Append("Person nummer " + x.Key + ": " + x.Value.firstName + " " + x.Value.lastName);
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}
