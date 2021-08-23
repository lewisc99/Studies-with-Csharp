using System;
using System.Collections.Generic;
using System.Text;

namespace teste.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public DateTime Birthdate { get; set; }


        public Client(string Name, string Email, DateTime Birthdate)
        {
            this.Name = Name;
            this.Email = Email;
            this.Birthdate = Birthdate;
        }
        public override string ToString()
        {
            return Name
                + ", ( "
                + this.Birthdate.ToString("dd/MM/yyyy")
                + ") - "
                + Email;
        }
    }
}
