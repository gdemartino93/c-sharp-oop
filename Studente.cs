using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Studente : Persona
    {
        private string classe;

        public Studente(string nome,string cognome,string dataDiNascita,string citta,string classe):base(nome,cognome,dataDiNascita,citta)
        {
            this.classe = classe;
        }
        public void Presentazione()
        {
            Console.WriteLine($"Sono {Nome} {Cognome}, sono nato il {DataDiNascita} a {Citta}. Frequenta la classe {classe}");
        }
    }
}
