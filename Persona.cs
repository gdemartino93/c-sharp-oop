using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Persona
    {
        private string nome;
        private string cognome;
        private string dataDiNascita;
        private string citta;
        private int stipendio;

        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string DataDiNascita { get; set; }
        public string Citta { get; set; }
        public int Stipendio { get { return stipendio; } set
            {
                if (value < 0)
                {
                    stipendio = 0;
                }
                else
                {
                    stipendio = value;
                }
            } 
        }


        public Persona( string nome, string cognome, string dataDiNascita, string citta, int stipendio = 0)
        {
            Nome = nome;
            Cognome = cognome;
            DataDiNascita = dataDiNascita;
            Citta = citta;
            Stipendio = stipendio;

        }

        public Persona(string nome,string cognome,string dataDiNascita,string citta)
        {
            Nome = nome;
            Cognome = cognome;
            DataDiNascita = dataDiNascita;
            Citta = citta;
        }

        public void Saluto(string nome)
        {
            Console.WriteLine($"Ciao {nome}");
        }
        public void Presentazione()
        {
            Console.WriteLine($"Sono {Nome} {Cognome}, sono nato il {DataDiNascita} a {Citta}. Il mio stipendio è di {Stipendio} euro");
        }

    }
}
