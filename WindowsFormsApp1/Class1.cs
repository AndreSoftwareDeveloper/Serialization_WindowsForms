using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Person
    {
        public Person(String firstName, String lastName, DateTime birthDate, int phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.phoneNumber = phoneNumber;
        }

        public String firstName, lastName;
        public DateTime birthDate;
        public int phoneNumber;


    }
}
