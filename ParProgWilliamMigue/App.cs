using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParProgWilliamMigue
{
    internal class App
    {
        public List<Pokemon> _pokemonListe = new List<Pokemon>();

        public void Kjør()
        {            
            StartMeny();
        }

        void StartMeny()
        {
            Console.Write("Hva vil du gjøre: \n1) Legg til pokemon\n2) Velg en pokemon\n");
            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    LagNyttPokemon();
                    break;
                case "2":
                    HarViPokemon();
                    break;
                default:
                    Console.WriteLine("Ærror fra startmeny");
                    StartMeny();
                    break;
            }
        }

        void LagNyttPokemon()
        {
            Pokemon newPokemon = new Pokemon();
            newPokemon.GiEtNavn();
            _pokemonListe.Add(newPokemon);
            Console.WriteLine($"Du la til: {newPokemon._name}\n");
            StartMeny();
        }

        void HarViPokemon()
        {
            Console.Clear();
            

            if (_pokemonListe.Count < 1)
            {
                Console.WriteLine("Du har ingen pokemon enda.");
                StartMeny();
            }
            else
            {
                VisAllePokemon();
                VelgPokemonPrompt();
            }
               
                
        }

        void VisAllePokemon()
        {
            int _numberOfPokemon = 0;

            Console.WriteLine("Dine pokemon:");
            foreach (Pokemon p in _pokemonListe)
            {
                _numberOfPokemon++;
                Console.WriteLine($"{_numberOfPokemon}. {p._name}");
            }
            
        }

        void VelgPokemonPrompt()
        {
            Console.WriteLine("Velg pokemon: ");
            var input = Convert.ToInt32(Console.ReadLine());
            PokemonActionPrompt(input);
        }

        void PokemonActionPrompt(int brukerValg)
        {
            for (int i = 0; i < _pokemonListe.Count; i++)
            {                
                if (brukerValg <= _pokemonListe.Count && brukerValg > 0)
                {
                    string valgtPokemon = _pokemonListe[brukerValg - 1]._name;
                    PokemonActions(valgtPokemon);
                }
                else
                {
                    Console.WriteLine("Ærror fra pokemonActionPrompt.");
                    VelgPokemonPrompt();
                }               
            }
        }

        void PokemonActions(string valgtPokemon)
        {
            Console.Write($"Hva vil du gjøre med {valgtPokemon}");
            Console.WriteLine($"\n1. Gi {valgtPokemon} mat \n2. Kos med {valgtPokemon}\n3. Gå ut med {valgtPokemon}");
            var input = Convert.ToInt32(Console.ReadLine());
            string name = valgtPokemon;
            switch (input)
            {
                case 1:
                    Mat(name);
                    break;
                case 2:
                    Kos(name);
                    break;
                case 3:
                    Toalette(name);
                    break;
                default:
                    Console.WriteLine("Ærror fra PokemonActions");
                    PokemonActions(name);
                    break;
            }
        }

        public void Mat(string name)
        {
            Console.WriteLine($"{name} er mett!");
        }

        public void Kos(string name)
        {
            Console.WriteLine($"{name} smiler!");
        }

        public void Toalette(string name)
        {
            Console.WriteLine($"{name} har gått på do!");
        }
    }
}
