using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Docente : Persona
    {
        private string materia;
        private int stipendio;

        public string Materia { get; set; }
        public int Stipendio { 
            get
            { 
                return stipendio;
            }
            set
            {
                if (value > 0)
                { 
                    stipendio = value;
                }
                else
                {
                    stipendio = 0; 
                }
            } 
        } 

        public Docente(string nome,string cognome,string dataDiNascita,string citta,int stipendio,string materia ):base(nome,cognome,dataDiNascita,citta,stipendio)
        {
            this.materia = materia;
            this.stipendio = stipendio;
        }
    }
}
