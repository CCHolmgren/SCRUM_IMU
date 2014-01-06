using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRUM
{
    class People
    {
        private Dictionary<int, Person> people = new Dictionary<int, Person>();
        private int __maxpersonindex = 0;
        private int maxPersonIndex
        {
            get
            {
                return __maxpersonindex++;
            }
        }

        public Person getPerson(int id)
        {
            return people.Single(p => p.Key == id).Value;
        }
        public int getId(Person person)
        {
            return people.Single(p => p.Value == person).Key;
        }
        public void addPerson(Person person)
        {
            people.Add(maxPersonIndex, person);
        }
        public void addPerson(string firstName, string lastName, string telephoneNumber)
        {
            Person person = new Person(firstName, lastName, telephoneNumber);
            people.Add(maxPersonIndex, person);
        }
        public void removePerson(Person person)
        {
            var key = people.Single(p=> p.Value == person).Key;
            people.Remove(key);
        }

        public List<Person> getPersonAll()
        {
            return people.Values.ToList();
        }
    }
}
