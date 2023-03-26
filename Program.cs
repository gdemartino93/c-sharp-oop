namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona luca = new Persona("Gianluca", "Rossi", "12/07/1993", "Barletta");
            Persona marco = new Persona("Marco", "Bianchi", "01/01/1980", "Roma", -100);

            marco.Saluto(luca.Nome);

        }
    }
}