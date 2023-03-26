namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
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

            Persona nuovoUser = new Persona(nome,cognome,dataDiNascita,citta,stipendio);


            Console.WriteLine($"{Persona.id} - La nuova persona creata si chiama {nuovoUser.Nome} {nuovoUser.Cognome}, è nata il {nuovoUser.DataDiNascita} a {nuovoUser.Citta}. Il suo stipendio è di {nuovoUser.Stipendio} euro");

        }
    }
}