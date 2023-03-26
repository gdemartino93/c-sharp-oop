namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona luca = new Persona("Gianluca", "Rossi", "12/07/1993", "Barletta");
            Persona marco = new Persona("Marco", "Bianchi", "01/01/1980", "Roma", 1200);
            //marco saluta luca
            marco.Saluto(luca.Nome);
            marco.Presentazione();

            luca.Saluto(marco.Nome);

        }
    }
}