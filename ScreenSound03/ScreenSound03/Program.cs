using ScreenSound03.Modelos;
using ScreenSound03.Filtros;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {

        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas,"pop")
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "U2");


        //var musicasPreferidas1 = new MusicasPreferidas("1");

        //musicasPreferidas1.AdicionarMusicasFavoritas(musicas[1]);
        //musicasPreferidas1.AdicionarMusicasFavoritas(musicas[377]);
        //musicasPreferidas1.AdicionarMusicasFavoritas(musicas[4]);
        //musicasPreferidas1.AdicionarMusicasFavoritas(musicas[6]);
        //musicasPreferidas1.AdicionarMusicasFavoritas(musicas[1467]);

        //musicasPreferidas1.ExibirMusicasFavoritas();

        var musicasPreferidas2 = new MusicasPreferidas("2");

        musicasPreferidas2.AdicionarMusicasFavoritas(musicas[500]);
        musicasPreferidas2.AdicionarMusicasFavoritas(musicas[637]);
        musicasPreferidas2.AdicionarMusicasFavoritas(musicas[428]);
        musicasPreferidas2.AdicionarMusicasFavoritas(musicas[13]);
        musicasPreferidas2.AdicionarMusicasFavoritas(musicas[71]);

        musicasPreferidas2.ExibirMusicasFavoritas();

        musicasPreferidas2.GerarArquivoJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}