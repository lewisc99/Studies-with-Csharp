using System;
using System.Collections.Generic;
using System.Text;

namespace teste.Entities
{
    class Client
    {
        public string name { get; set; }
        public string email { get; set; }

        public DateTime birthDate { get; set; }


        public Client(string name, string email, DateTime birthdate)
        {
            this.name = name;
            this.email = email;
            this.birthDate = birthDate;
        }
    }
}
