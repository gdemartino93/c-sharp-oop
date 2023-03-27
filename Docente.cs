using OOP;

internal class Docente : Persona , IEquatable<Docente>
{
    private static int lastId = 0;
    private int id;
    private string materia;
    private int stipendio;

    public override string Nome { get; set; }
    public override string Cognome { get; set; }
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
    public override void Presentazione()
    {
        Console.WriteLine($"ID- {Id} || Sono {Nome} {Cognome}, sono nato il {DataDiNascita} a {Citta}. Insegno {Materia} e il mio stipendio è di {Stipendio}");
    }

    //metodo astratto che va importato obbligatoriamente
    public override void Saluto()
    {
        Console.WriteLine("Buongiorno sono il docente");
    }
    //interfaccia che potremmo usare per controllare se 2 oggetti hanno la stessa materia
    public bool Equals(Docente docente)
    {
        return Materia == docente.Materia;
    }
}
