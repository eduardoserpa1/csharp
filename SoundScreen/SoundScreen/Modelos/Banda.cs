namespace ScreenSound.Modelos;
class Banda
{
    private List<Album> albuns = new List<Album>();
    private List<int> notas = new List<int>();
    public double Media => notas.Average();
    public string Nome { get;}


    public Banda(string nome)
    {
        Nome = nome;
    }
    public void AdicionarAlbum(Album album) 
    { 
        albuns.Add(album);
    }

    public void AdicionarNota(int nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}");
        foreach(Album album in albuns) 
        {
            Console.WriteLine($"Álbum: {album.Nome} ({album.DuracaoTotal})");
        }
    }
}