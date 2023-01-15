using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mathee_Stephanus_PRG282_Exam
{
    internal class User
    {
        string fName, lName, email, password, gender;
        DateTime birthdate;

        public User(string fName, string lName, string email, string password, string gender, DateTime birthdate)
        {
            this.fName = fName;
            this.lName = lName;
            this.email = email;
            this.password = password;
            this.gender = gender;
            this.birthdate = birthdate;
        }

        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public string Gender { get => gender; set => gender = value; }
        public DateTime Birthdate { get => birthdate; set => birthdate = value; }

        public override string ToString()
        {
            return $"{fName},{LName},{email},{password},{gender},{birthdate}";
        }
    }
}
