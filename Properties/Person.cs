using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Person
    {

        public Person(DateTime birthdate)
        {
            this.Birthdate = birthdate;
        }
        public  DateTime Birthdate { get; private set; }

        public int Age
        {
            get {
                var Age = DateTime.Now - Birthdate;
                var Years = Age.Days / 365;

                return Years;

            }
        }

    }
}
