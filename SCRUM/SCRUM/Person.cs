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
            set
            {
                _firstName = value;
            }
            get
            {
                return _firstName;
            }
        }
        public string lastName
        {
            set
            {
                _lastName = value;
            }
            get
            {
                return _lastName;
            }
        }
        public string telephoneNumber
        {
            set
            {
                _telephoneNumber = value;
            }
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
        public Person()
            : this("", "", "")
        {}
        public Person(string firstname, string lastname, string telephonenumber)
        {
            _firstName = firstname;
            _lastName = lastname;
            _telephoneNumber = telephonenumber;
        }
        public override string ToString()
        {
            return this.ToString("\n");
        }
        public string ToString(string delimiter = "\n")
        {
            return firstName + delimiter + lastName + delimiter + telephoneNumber;
        }
        
    }
}
