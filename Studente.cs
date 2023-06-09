﻿using System;
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

        public override string Nome { get; set; }
        public override string Cognome { get; set; }
        public int Id { get; set; }
        public Studente(string nome,string cognome,string dataDiNascita,string citta,string classe):base(nome,cognome,dataDiNascita,citta)
        {
            this.classe = classe;
            Id = ++lastId;
        }
        public override void Presentazione()
        {
            Console.WriteLine($"ID-{Id} || Sono {Nome} {Cognome}, sono nato il {DataDiNascita} a {Citta}. Frequenta la classe {classe}");
        }
        //metodo astratto di persona
        public override void Saluto()
        {
            Console.WriteLine("Ciao raga come va? sono lo studente");
        }
    }
}
