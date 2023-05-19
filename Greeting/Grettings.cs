using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greeting
{
    public class Greetings
    {
        public string Greet(string[] names)
        {
            if (names == null || names.Length == 0)
            {
                return "Hello, my friend!";
            }
            else if (names.Length == 1)
            {
                return GenerateGreetingForSingleName(names[0]);
            }
            else
            {
                string[] normalNames = names.Where(name => !IsShouted(name)).ToArray();
                string[] shoutedNames = names.Where(name => IsShouted(name)).ToArray();

                string normalGreeting = GenerateGreetingForMultipleNames(normalNames);
                string shoutedGreeting = GenerateGreetingForShoutedNames(shoutedNames);

                string greeting = $"{normalGreeting}{(!string.IsNullOrEmpty(normalGreeting) && !string.IsNullOrEmpty(shoutedGreeting) ? " " : "")}{shoutedGreeting}";
                return greeting;
            }
        }

        private bool IsShouted(string name)
        {
            return name == name.ToUpper();
        }

        private string GenerateGreetingForSingleName(string name)
        {
            if (IsShouted(name))
            {
                return $"HELLO {name}!";
            }
            else
            {
                return $"Hello, {name}!";
            }
        }

        private string GenerateGreetingForMultipleNames(string[] names)
        {
            if (names.Length == 0)
            {
                return "";
            }
            else if (names.Length == 1)
            {
                return $"Hello, {names[0]}!";
            }
            else if (names.Length == 2)
            {
                return $"Hello, {names[0]} and {names[1]}!";
            }
            else
            {
                string lastTwoNames = $", {names[names.Length - 2]} and {names[names.Length - 1]}";
                string remainingNames = string.Join(", ", names.Take(names.Length - 2));
                return $"Hello, {remainingNames}{lastTwoNames}!";
            }
        }

        private string GenerateGreetingForShoutedNames(string[] names)
        {
            if (names.Length == 0)
            {
                return "";
            }
            else if (names.Length == 1)
            {
                return $"AND HELLO {names[0]}!";
            }
            else if (names.Length == 2)
            {
                string onlyTwoNames = $"{names[0]} AND {names[1]}";
                return $"AND HELLO {onlyTwoNames}!";
            }    
            else
            {
                string remainingNames = string.Join(" ", names.Skip(0));
                string LastTwoNames = $"{names[names.Length - 2]} AND {names[names.Length - 1]}";
                return $"AND HELLO{(!string.IsNullOrEmpty(remainingNames) ? $" {remainingNames}" : "")}, {remainingNames}!";
            }
        }
    }
}
