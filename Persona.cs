using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class Persona
    {
        private static int lastId = 0;
        private int id;
        private string nome;
        private string cognome;
        private string dataDiNascita;
        private string citta;


        abstract public string Nome { get; set; }
        abstract public string Cognome { get; set; }
        public string DataDiNascita { get; set; }
        public string Citta { get; set; }

        public int Id { get; set; }

        public Persona(string nome, string cognome, string dataDiNascita, string citta)
        {
            Nome = nome;
            Cognome = cognome;
            DataDiNascita = dataDiNascita;
            Citta = citta;
            Id = lastId;
        }

        public abstract void Saluto();

        public virtual void Presentazione()
        {
            Console.WriteLine($"ID-{Id}| Sono {Nome} {Cognome}, sono nato il {DataDiNascita} a {Citta}.");
        }
    }
}

