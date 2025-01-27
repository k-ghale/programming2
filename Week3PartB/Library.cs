
class Library{

    private static List<Song> songs {get; set; } = new List<Song>();

    public static void LoadSongs(string filename){
        // Open the file for reading
        using (StreamReader reader = new StreamReader(filename))
        {
            string title;
            while ((title = reader.ReadLine()) != null && title.Trim() != "")
            {
                // Read the next three lines for artist, length, and genre
                string artist = reader.ReadLine();
                string lengthStr = reader.ReadLine();
                string genreStr = reader.ReadLine();

                // Convert the length to a double
                double length = Convert.ToDouble(lengthStr);

                // Parse the genre to an enum
                SongGenre genre = Enum.Parse<SongGenre>(genreStr, true);

                // Create a new Song object
                Song song = new Song(title, artist, length, genre);

                // Add the song to the Songs collection
                songs.Add(song);

            }
        }
    }

    public static void DisplaySongs(){
        foreach (Song item in songs)
        {
            Console.WriteLine(item); 
        }
    }

    public static void DisplaySongs(double longerThan){
        foreach (Song item in songs)
        {
           if(longerThan < item.Length){
            Console.WriteLine(item);
           }
        }
    }

    public static void DisplaySongs(SongGenre genre){
        foreach (Song item in songs)
        {
           if(genre == item.Genre){
               Console.WriteLine(item);
           }
        }
    }

    public static void DisplaySongs(string artist){
        foreach (Song item in songs)
        {
           if(artist == item.Artist){
               Console.WriteLine(item);
           }
        }
    }
}


