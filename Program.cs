using System;
using System.Collections.Generic;

namespace ConsoleAppLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Client> clients = new List<Client>
            {
                new Client { _prenom = "Patrice1", _nom = "HANNE1", _age = 10 },
                new Client { _prenom = "Patrice2", _nom = "HANNE2", _age = 20 },
                new Client { _prenom = "Patrice3", _nom = "HANNE3", _age = 25 },
                new Client { _prenom = "Patrice4", _nom = "HANNE4", _age = 40 },
                new Client { _prenom = "Patrice7", _nom = "HANNE7", _age = 30 },
                new Client { _prenom = "Patrice6", _nom = "HANNE6", _age = 35 },
                new Client { _prenom = "Patrice5", _nom = "HANNE5", _age = 50 },
            };

            IEnumerable<Client> requete = 
                from cli in clients 
                where cli._age >= 25 && cli._age < 50 
                orderby cli._prenom 
                select cli;

            foreach(Client c in requete) 
            {
                Console.WriteLine(c._prenom);
            }
        }
    }
}