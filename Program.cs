namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona prima = new Persona("Gianluca", "Rossi", "12/07/1993", "Barletta");
            Persona dipendente = new Persona("Marco", "Bianchi", "01/01/1980", "Roma", -100);
            Console.WriteLine(dipendente.Stipendio);

        }
    }
}