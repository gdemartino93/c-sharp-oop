namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string risposta = "y"; //settiamo risposta y per eseguire il ciclo per la prima volta
            List<Docente> docenti = new List<Docente>(); //creiamo una list di docenti
            List<Studente> studenti = new List<Studente>(); //creiamo una list di studenti

            while (risposta == "y")
            {
                Console.WriteLine("Inserisci il nome della persona");
                string nome = Console.ReadLine();
                Console.WriteLine("Inserisci il cognome della persona");
                string cognome = Console.ReadLine();
                Console.WriteLine("Inserisci la data di nascita della persona");
                string dataDiNascita = Console.ReadLine();
                Console.WriteLine("Inserisci la città della persona");
                string citta = Console.ReadLine();
                bool haStipendio; //dichiariamo la variabile per capire se l'oggetto sarà uno studente o un docente

                //gestiamo l'input dell'utente per la domanda dello stipendio
                while (true)
                {
                    Console.WriteLine("Ha uno stipendio?");
                    string input = Console.ReadLine().ToLower();
                    if (input == "y" || input == "yes" || input == "si" || input == "true" || input == "vero" || input == "s")
                    {
                        haStipendio = true;
                        break;
                    }
                    else if (input == "n" || input == "no" || input == "false" || input == "f")
                    {
                        haStipendio = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Inserisci una risposta valida");
                        Console.WriteLine("Le risposte valide sono: y,yes,si,true,vero,s oppure n,no,false,n");
                    }
                }
                //se ha uno stipendio sarà un docente
                if (haStipendio)
                {
                    Console.WriteLine("Inserisci lo stipendio della persona");
                    int stipendio = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Inserisci la materia insegnata");
                    string materia = Console.ReadLine();
                    Docente docente = new Docente(nome, cognome, dataDiNascita, citta, stipendio, materia);
                    docenti.Add(docente);

                    Console.WriteLine("Vuoi inserire un'altra persona? y/n");
                    risposta = Console.ReadLine().ToLower();
                }
                //altrimenti sarà uno studente
                else
                {
                    Console.WriteLine("Inserisci la classe dello studente");
                    string classe = Console.ReadLine();
                    Studente studente = new Studente(nome, cognome, dataDiNascita, citta, classe);
                    studenti.Add(studente);

                    Console.WriteLine("Vuoi inserire un'altra persona? y/n");
                    risposta = Console.ReadLine().ToLower();
                }
            }
            foreach (Docente docente in docenti)
            {
                docente.Presentazione();
            }
            foreach (Studente studente in studenti)
            {
                studente.Presentazione();
            }

            for (int i = 0;i < docenti.Count;i++)
            {
                Console.WriteLine(docenti.Count);
            }
        }
    }
}
