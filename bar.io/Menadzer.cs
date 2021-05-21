using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bar.io
{
    public class Menadzer
    {
        public string Name { get; set; }
        public static Dictionary<String, List<Rezervacija>> Reservations { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public Menadzer(string name)
        {
            Name = name;
            Reservations = new Dictionary<String, List<Rezervacija>>();
            Username = Name.ToLower() + "123";
            Password = Username + "!";
        }
    }
}
