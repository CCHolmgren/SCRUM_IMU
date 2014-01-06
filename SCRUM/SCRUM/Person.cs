using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRUM
{
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private string _telephoneNumber;
        private string _id;

        public string firstName
        {
            get
            {
                return _firstName;
            }
        }
        public string lastName
        {
            get
            {
                return _lastName;
            }
        }
        public string telephoneNumber
        {
            get
            {
                return _telephoneNumber;
            }
        }
        public string id
        {
            set
            {
                _id = value;
            }
            get
            {
                return _id;
            }
        }

        public Person(string firstname, string lastname, string telephonenumber)
        {
            _firstName = firstname;
            _lastName = lastname;
            _telephoneNumber = telephonenumber;
        }

        public override string ToString()
        {
            return firstName + "\n" + lastName + "\n" + telephoneNumber;
        }
    }
}
