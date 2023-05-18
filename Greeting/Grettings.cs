using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    public class Greetings
    {
        public string Greet(string[] name)
        {
            if (name == null || name.Length == 0)
            {
                name = new string[] { "my friend" };
                return $"Hello, my friend!";
            }
            if (name.Length == 1)
            {
                if (name[0] == null) return $"Hello, my friend!";
                if (name.All(s => s.All(char.IsUpper))) return $"HELLO {name[0]}!";
                else return $"Hello, {name[0]}!";
            }
            if (name.Length == 2)
            {
                return $"Hello, {name[0]} and {name[1]}!";
            }
            if (name.Length > 2)
            {
                int l = name.Length;
                string greeting = "Hello, ";
                for (int i = 0; i < (l-1); i++)
                {
                    greeting += name[i] + ", ";
                }
                return $"{greeting}and {name[l-1]}!";
            }
            else return string.Empty;
        }
    }
}
