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
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Person getPerson(int id)
        {
            return people.Single(p => p.Key == id.ToString()).Value;
        }
        /// <summary>
        /// Given id returns a specific person associated with that id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Person getPerson(string id)
        {
            return people.Single(p => p.Key == id).Value;
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
        /// <returns></returns>
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
        /// <returns></returns>
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
        /// </summary>
        /// <param name="person"></param>
        public void removePerson(Person person)
        {
            var key = people.Single(p=> p.Value == person).Key;
            people.Remove(key);
        }
        /// <summary>
        /// Checks if person is in the dictionary or not
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public bool existsPerson(Person person)
        {
            return people.Any(p => p.Value == person);
        }
        /// <summary>
        /// Returns all persons
        /// </summary>
        /// <returns></returns>
        public List<Person> getPersonAll()
        {
            return people.Values.ToList();
        }
        /// <summary>
        /// Overrides object.ToString() so we get 
        /// the whole dictionary instead of some useless info
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var x in people)
            {
                sb.Append(x.Key + ": " + x.Value.firstName);
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}
