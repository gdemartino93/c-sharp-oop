namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona prima = new("Gianluca", "Rossi", "12/07/1993", "Barletta",-10);
            Console.WriteLine(prima.Stipendio);
        }
    }
}