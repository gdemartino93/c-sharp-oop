using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Studente : Persona
    {
        private static int lastId = 0;
        private int id;
        private string classe;

        public int Id { get; set; }
        public Studente(string nome,string cognome,string dataDiNascita,string citta,string classe):base(nome,cognome,dataDiNascita,citta)
        {
            this.classe = classe;
            Id = ++lastId;
        }
        public void Presentazione()
        {
            Console.WriteLine($"ID-{Id} || Sono {Nome} {Cognome}, sono nato il {DataDiNascita} a {Citta}. Frequenta la classe {classe}");
        }
    }
}
