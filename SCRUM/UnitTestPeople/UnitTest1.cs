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
        public void TestGetPersonWithID()
        {
            People people = new People();
            Person person = new Person();

            people.addPerson(person);
            Assert.AreSame(person, people.getPerson(person.id).Item2);
        }
        [TestMethod]
        public void TestGetPersonWithIDFail()
        {
            People people = new People();
            Person person = new Person();

            people.addPerson(person);

            Assert.AreEqual(false, people.getPerson(2).Item1);
        }
        [TestMethod]
        public void TestGetPersonFail()
        {
            People people = new People();
            Assert.IsFalse(people.getPerson(0).Item1);
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
        public void TestRemoveNonExistant()
        {
            People people = new People();
            people.removePerson(new Person());
        }
        /*[TestMethod]
        public void TestGetAll()
        {
            People people = new People();
            Person one = new Person();
            Person two = new Person();
            Person three = new Person();
            people.addPerson(one);
            people.addPerson(two);
            people.addPerson(three);
            List<Person> personList = people.getPersonList();
            List<Person> expectedPersonList = new List<Person>();

            
            expectedPersonList.Add(one);
            expectedPersonList.Add(two);
            expectedPersonList.Add(three);
            expectedPersonList.Sort();
            personList.Sort();

            for(int i = 0; i < expectedPersonList.Count; i++)
            {
                if (expectedPersonList[i] != personList[i])
                    Assert.Fail();
            }
        }*/
        [TestMethod]
        public void TestOneEmptyNotSameAsNewEmpty()
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
