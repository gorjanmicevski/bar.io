using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bar.io
{
    public class Sanker
    {
        public string Name { set; get; }
        public List<Naracka> Orders { set; get; }
        public string Username { set; get; }
        public string Password { set; get; }
        public Sanker(string name)
        {
            Name = name;
            Orders = new List<Naracka>();
            Username = Name.ToLower() + "123";
            Password = Username + "!";
        }
        public Sanker(string name,string pw)
        {
            this.Name = name;
            this.Password = pw;
            Orders = new List<Naracka>();
            Username = Name.ToLower() + "123";
            Password = Username + "!";
        }
    }
}
