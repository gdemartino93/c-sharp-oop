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


        public Persona(string nome, string cognome, string dataDiNascita, string citta)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.dataDiNascita = dataDiNascita;
            this.citta = citta;
        }
    }
}
