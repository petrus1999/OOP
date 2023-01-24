using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
     class Learners
    {
        public string firstname;
        public string lastname;
        public string gender;
        public char initial;
        public int age;

        public Learners(string Firstname, string Lastname, string Gender, char Initial, int Age)
        {
            firstname = Firstname;
            lastname = Lastname;
            gender = Gender;
            initial = Initial;
            age = Age;


        }
    }
}
