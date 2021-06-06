using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bar.io
{
    public class Korisnici
    {
        public static List<Menadzer> Menadzeri = new List<Menadzer>(3) { new Menadzer("Boban"), new Menadzer("Gorjan"), new Menadzer("Bojan") };
        public static List<Kelner> Kelneri = new List<Kelner>(10) { new Kelner("Dimitar"), new Kelner("Andrej"), new Kelner("Trajce"), new Kelner("Filip") };
        public static List<Sanker> Sankeri = new List<Sanker>(10) { new Sanker("Goran"), new Sanker("Zoran"), new Sanker("Vane"), new Sanker("Ivan") };

        public static Menadzer getMenadzer(String username, String password)
        {
            foreach(Menadzer m in Menadzeri)
            {
                if(m.Username == username && m.Password == password)
                {
                    return m;
                }
            }
            return null;
        }
        public static Kelner getKelner(String username, String password)
        {
            foreach (Kelner m in Kelneri)
            {
                if (m.Username == username && m.Password == password)
                {
                    return m;
                }
            }
            return null;
        }
        public static Sanker getSanker(String username, String password)
        {
            foreach (Sanker m in Sankeri)
            {
                if (m.Username == username && m.Password == password)
                {
                    return m;
                }
            }
            return null;
        }
        public static bool checkUsernameMenadzer(String username)
        {
            foreach(Menadzer m in Menadzeri)
            {
                if (m.Username == username)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool checkUsernameKelner(String username)
        {
            foreach (Kelner m in Kelneri)
            {
                if (m.Username == username)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool checkUsernameSanker(String username)
        {
            foreach (Sanker m in Sankeri)
            {
                if (m.Username == username)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool checkPasswordMenadzer(String password)
        {
            foreach (Menadzer m in Menadzeri)
            {
                if (m.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool checkPasswordSanker(String password)
        {
            foreach (Sanker m in Sankeri)
            {
                if (m.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool checkPasswordKelner(String password)
        {
            foreach (Kelner m in Kelneri)
            {
                if (m.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool checkMenadzer(String username, String password)
        {
            foreach (Menadzer m in Menadzeri)
            {
                if(m.Username == username && m.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool checkSanker(String username, String password)
        {
            foreach (Sanker m in Sankeri)
            {
                if (m.Username == username && m.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool checkKelner(String username, String password)
        {
            foreach (Kelner m in Kelneri)
            {
                if (m.Username == username && m.Password == password)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
