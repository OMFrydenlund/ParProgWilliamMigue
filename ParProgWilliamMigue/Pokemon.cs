using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgWilliamMigue
{
    internal class Pokemon
    {
        // hva HAR klassen/hva GJØR klassen
        // prop + Enter for property -- ctor for constructor (shortcuts)
        public string _name { get; private set; }

        public Pokemon()
        {

        }
        public Pokemon(string name)
        {
            _name = name;
        }

        public void GiEtNavn()
        {
            Console.Write("What is the name of your new pokemon? ");
            string input = Console.ReadLine();
            _name = input;

        }

        

        public void PrintName()
        {
            Console.WriteLine($"Name: {_name}");
        }
    }
}
