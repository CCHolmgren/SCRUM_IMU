using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRUM
{
    public class People
    {
        private Dictionary<string, Person> people = new Dictionary<string, Person>();
        private int __maxpersonindex = 0;
        private string maxPersonIndex
        {
            get
            {
                return (__maxpersonindex++).ToString();
            }
        }

        public Person getPerson(Person person)
        {
            return people.Single(p => p.Key == person.id).Value;
        }
        /*public int getId(Person person)
        {
            return people.Single(p => p.Value == person).Key;
        }*/
        public Person addPerson(Person person)
        {
            string index = maxPersonIndex;
            person.id = index;
            people.Add(index, person);
            return person;
        }
        public Person addPerson(string firstName, string lastName, string telephoneNumber)
        {
            Person person = new Person(firstName, lastName, telephoneNumber);
            string index = maxPersonIndex;
            person.id = index;
            people.Add(index, person);
            return person;
        }
        public void removePerson(Person person)
        {
            var key = people.Single(p=> p.Value == person).Key;
            people.Remove(key);
        }
        public bool existsPerson(Person person)
        {
            return people.Any(p => p.Value == person);
        }
        public List<Person> getPersonAll()
        {
            return people.Values.ToList();
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var x in people)
            {
                sb.Append(x.Key + x.Value);
            }
            return sb.ToString();
        }
    }
}
