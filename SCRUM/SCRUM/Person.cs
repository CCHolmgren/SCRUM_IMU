using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRUM
{
    /// <summary>
    /// Represents a single Person
    /// </summary>
    public class Person
    {
        private string _firstName;
        private string _lastName;
        private string _telephoneNumber;
        private string _id;

        /// <summary>
        /// getter and setter för firstName
        /// Might contain verification later on
        /// </summary>
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
        /// <summary>
        /// Getter and setter for lastName
        /// Might contain verification later on
        /// </summary>
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
        /// <summary>
        /// Getter and setter for telephoneNumber
        /// Might contain verification later on
        /// </summary>
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
        /// <summary>
        /// getter and setter for id
        /// Might contain verification later on
        /// </summary>
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
        /// <summary>
        /// Empty constructor 
        /// uses Person(,,)
        /// </summary>
        public Person()
            : this("", "", "")
        {}
        /// <summary>
        /// Constructor taking firstname lastname and telephonenumber
        /// This uses the public getters and setters which means that it might do some verification on the input later on
        /// Or throw an error if something is wrong
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="telephonenumber"></param>
        public Person(string firstname, string lastname, string telephonenumber)
        {
            firstName = firstname;
            lastName = lastname;
            telephoneNumber = telephonenumber;
            id = "0";
        }
        /// <summary>
        /// Overrides the object.ToString() so we can get some decent prints
        /// </summary>
        /// <returns>this.ToString("\n")</returns>
        public override string ToString()
        {
            return this.ToString("\n");
        }
        /// <summary>
        /// Overloaded function so we can use a specific delimiter
        /// </summary>
        /// <param name="delimiter">Delimits firstName lastName and telephoneNumber in that order</param>
        /// <returns>String representation of the object</returns>
        public string ToString(string delimiter = "\n")
        {
            return firstName + delimiter + lastName + delimiter + telephoneNumber;
        }
        public string ToString( bool verbose, string delimiter = "\n")
        {
            return "Förnamn: " + firstName + delimiter + "Efternamn: " + lastName + delimiter + "Telefonnummer: " + telephoneNumber + delimiter;
        }
    }
}
