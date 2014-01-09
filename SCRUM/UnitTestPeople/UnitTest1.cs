using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SCRUM;

namespace UnitTestPeople
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestExistsPerson()
        {
            People people = new People();
            Person person = people.addPerson("c", "c", "c");
            Assert.IsTrue(people.existsPerson(person));
        }
        [TestMethod]
        public void TestDontExistPerson()
        {
            People people = new People();
            Person person = people.addPerson("c", "c", "c");

            Assert.IsFalse(people.existsPerson(new Person("", "", "")));
        }
        [TestMethod]
        public void TestGetPerson()
        {
            People people = new People();
            Person person = new Person("c", "c", "c");

            people.addPerson(person);
            Person result = people.getPerson(person);

            Assert.AreSame(person, result);
        }
        [TestMethod]
        public void TestRemovePerson()
        {
            People people = new People();
            Person person = new Person("Christoffer", "Holmgren", "07382344460");

            people.addPerson(person);
            Assert.IsTrue(people.existsPerson(person));

            people.removePerson(person);
            Assert.IsFalse(people.existsPerson(person));
        }
        [TestMethod]
        public void TestGetAll()
        {
        }
        [TestMethod]
        public void TestOneEmptyNotSameAsEmpty()
        {
            People people = new People();
            people.addPerson(new Person());
            Assert.IsFalse(people.getPerson(0).Equals(new Person()));
        }
        [TestMethod]
        public void TestToStringDelimiter()
        {
            Assert.AreEqual((new Person()).ToString(), (new Person()).ToString("\n"));
        }
    }
}
