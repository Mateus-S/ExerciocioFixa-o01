using System;
using System.Collections.Generic;
using System.Text;

namespace Exercio01Fixacao.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDAte { get; set; }

        public Client()
        {

        }

        public Client(string name, string email, DateTime birthDAte)
        {
            Name = name;
            Email = email;
            BirthDAte = birthDAte;
        }
    }
}
