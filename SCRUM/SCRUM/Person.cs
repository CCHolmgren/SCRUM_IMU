using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRUM
{
    class Person
    {
        public string firstName;
        public string lastName;
        public string telephoneNumber;

        public Person(string firstname, string lastname, string telephonenumber)
        {
            firstName = firstname;
            lastName = lastname;
            telephoneNumber = telephonenumber;
        }

        public override string ToString()
        {
            return firstName + "\n" + lastName + "\n" + telephoneNumber;
        }
    }
}
