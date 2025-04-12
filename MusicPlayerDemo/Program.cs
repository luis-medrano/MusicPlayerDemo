namespace MusicPlayerDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Song song1 = new Song("Thriller","Billie Jean","Una canción icónica con un bajo inolvidable que habla sobre una mujer que afirma que el hijo del cantante es suyo.","Pop");
            song1.Album = "Thriller";
            Console.WriteLine(song1.Album);

            Song song2 = new Song("Play","Cuando Pienses en Volver","Una balada nostálgica que expresa el deseo de recuperar un amor que se fue.","Rock/Pop");
            song2.Album = "Play";
            Console.WriteLine(song2.Album);

            Artist artist1 = new Artist("Michael Jackson","Pop","Thriller","Epic Records",13);
            artist1.album = "Thriller";
            Console.WriteLine(artist1.album);

            Artist artist2 = new Artist("Pedro Suárez Vértiz","Rock/Pop","Play","Sony Music",0);
            artist2.album = "Play";
            Console.WriteLine(artist2.album);
        }
    }
}
