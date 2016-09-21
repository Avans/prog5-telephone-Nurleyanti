using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefoonBoek
{
    class Person
    {

        private String firstName;

        private String lastName;

        private int telephoneNumber;
        private String fullName { get { return firstName + " " + lastName; } }

        public Person(String firstName, String lastName, int number)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.telephoneNumber = number;
        }

        public int TelephoneNumber
        {
            get
            {
                return telephoneNumber;
            }
        }

        public string Firstname
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }
    }

    
}

