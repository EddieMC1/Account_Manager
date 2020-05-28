using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManagerAssistent
{
    class Account
    {
        // Datenfelder
        private int id;
        private string anbieter;
        private string benutzer;
        private string passwort;
        private string website;


        // Konstruktor
        public Account(int id, string anbieter, string benutzer, string passwort, string website)
        {
            this.id = id;
            this.anbieter = anbieter;
            this.benutzer = benutzer;
            this.passwort = passwort;
            this.website = website;
        }

        // Getter/Setter
        public int Id { get => id; set => id = value; }
        public string Anbieter { get => anbieter; set => anbieter = value; }
        public string Benutzer { get => benutzer; set => benutzer = value; }
        public string Passwort { get => passwort; set => passwort = value; }
        public string Website { get => website; set => website = value; }
        
    }
}
