using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    public class Greetings
    {
        public string Greet(string name)
        {
            if (name == null) name = "my friend";
            return $"Hello, {name}!";
        }
    }
}
