namespace Spotify_Album.Models
{
    public class Album{
        public int id{ get; set;}
        public string? nombre{ get; set;}
        public string? artista{ get; set;}
        public string? lanzamiento{ get; set;}
        public string? imgPrincipal{ get; set;}
        public string? Spotify{ get; set;}
        public string? color{ get; set;}
        public string[]? canciones{ get; set;}
    }
}