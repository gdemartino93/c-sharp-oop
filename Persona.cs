using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Persona
    {
        private static int id = 0;
        private string nome;
        private string cognome;
        private string dataDiNascita;
        private string citta;

        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string DataDiNascita { get; set; }
        public string Citta { get; set; }

        public Persona(string nome, string cognome, string dataDiNascita, string citta)
        {
            Nome = nome;
            Cognome = cognome;
            DataDiNascita = dataDiNascita;
            Citta = citta;
            id++;
        }

        public void Saluto()
        {
            Console.WriteLine("Ciao sono una persona");
        }

        public void Presentazione()
        {
            Console.WriteLine($"ID-{id}| Sono {Nome} {Cognome}, sono nato il {DataDiNascita} a {Citta}.");
        }
    }
}

