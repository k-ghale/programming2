﻿
class Program
{

    public static void Main(string[] args){

        //To test the constructor and the ToString method
        Console.WriteLine(new Song("Baby", "Justin Bebier", 3.35, SongGenre.Pop));
        //This is first time that you are using the bitwise or. It is used to specify a combination of genres
        Console.WriteLine(new Song("The Promise", "Chris Cornell", 4.26, SongGenre.Country | SongGenre.Rock));
        Library.LoadSongs("./bin/Debug/net8.0/Week_03_lab_09_songs4.txt"); //Class methods are invoke with the class name
        Console.WriteLine("\n\nAll songs");
        Library.DisplaySongs();
        SongGenre genre = SongGenre.Rock;
        Console.WriteLine($"\n\n{genre} songs");
        Library.DisplaySongs(genre);
        string artist = "Bob Dylan";
        Console.WriteLine($"\n\nSongs by {artist}");
        Library.DisplaySongs(artist);
        double length = 5.0;
        Console.WriteLine($"\n\nSongs more than {length}mins");
        Library.DisplaySongs(length);

    }
}

