namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string risposta = "y"; //settiamo risposta y per eseguire il ciclo per la prima volta
            List<Persona> persone = new List<Persona>(); //creiamo una list di persone

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
                Console.WriteLine("Inserisci lo stipendio della persona");
                int stipendio = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Vuoi inserire un altra persona? y/n");
                risposta = (Console.ReadLine()).ToLower();

                Persona nuovoUser = new Persona(nome,cognome,dataDiNascita,citta,stipendio);
                persone.Add(nuovoUser);//pushiamo nuovouser all'interno della lista

          }

          foreach(Persona persona in persone)
            {
                persona.Presentazione();
            }
        }
    }
}