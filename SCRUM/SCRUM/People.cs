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
        private int maxPersonIndex = 0;

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
            maxPersonIndex+=1;
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
