namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string risposta = "y"; //settiamo risposta y per eseguire il ciclo per la prima volta
            List <Docente> docenti = new List<Docente> ();//creiamo una list di docenti
            List <Studente> studenti = new List<Studente> ();//creiamo una list di studenti

          while(risposta == "y")
            {
                Console.WriteLine("Inserisci il nome della persona");
                string nome = Console.ReadLine();
                Console.WriteLine("Inserisci il cognome della persona");
                string cognome = Console.ReadLine();
                Console.WriteLine("Inserisci la data di nascita della persona");
                string dataDiNascita = Console.ReadLine();
                Console.WriteLine("Inserisci la città della persona");
                string citta = Console.ReadLine();

                Console.WriteLine("Ha uno stipendio?");
                Boolean haStipendio = Convert.ToBoolean( Console.ReadLine());
                if ( haStipendio )
                {
                    Console.WriteLine("Inserisci lo stipendio della persona");
                    int stipendio = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Inserisci la materia insegnata");
                    string materia = Console.ReadLine();
                    Docente docente = new Docente(nome, cognome, dataDiNascita, citta, stipendio, materia);
                    docenti.Add(docente);
                    Console.WriteLine("Vuoi inserire un altra persona? y/n");
                    risposta = (Console.ReadLine()).ToLower();
                }

                foreach(Docente docente in docenti)
                {
                    Console.WriteLine(docente.Nome);
                }

          

 

          }

        }
    }
}