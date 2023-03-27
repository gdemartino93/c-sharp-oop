using OOP;

internal class Docente : Persona
{
    private static int lastId = 0;
    private int id;
    private string materia;
    private int stipendio;

    public int Id { get { return id; } }
    public string Materia { get; set; }
    public int Stipendio
    {
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

    public Docente(string nome, string cognome, string dataDiNascita, string citta, int stipendio, string materia) : base(nome, cognome, dataDiNascita, citta)
    {
        Materia = materia;
        Stipendio = stipendio;
        id = ++lastId;
    }
    public void Presentazione()
    {
        Console.WriteLine($"ID- {Id} || Sono {Nome} {Cognome}, sono nato il {DataDiNascita} a {Citta}. Insegno {materia} e il mio stipendio è di {stipendio}");
    }
}
