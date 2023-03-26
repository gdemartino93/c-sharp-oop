namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona luca = new Persona("Gianluca", "Rossi", "12/07/1993", "Barletta");
            Persona marco = new Persona("Marco", "Bianchi", "01/01/1980", "Roma", 1200);
            Persona anna = new Persona("Anna","Verdi", "12/12/1970", "Bari",-100);

            Console.WriteLine(anna.Stipendio);
        }
    }
}