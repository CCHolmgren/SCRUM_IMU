﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRUM
{
    class Program
    {
        static void Main(string[] args)
        {
            Person chris = new Person("Chris","Holm","0738234460");
            People people = new People();
            people.addPerson(chris);
            Person test = people.getPerson(people.getId(chris));
            Console.WriteLine(test);

            Person towe = new Person("Towe", "1", "2");
            people.addPerson(towe);
            test = people.getPerson(people.getId(towe));
            Console.WriteLine(people.getId(towe));
            Console.WriteLine(test);

            Console.ReadLine();
        }
    }
}