
class Song
{

    public string Artist {get;}
    public string Title {get;}
    public double Length {get;}
    public SongGenre Genre {get;}

    public Song(string title, string artist, double length, SongGenre genre){
        Artist = artist;
        Title = title;
        Length = length;
        Genre = genre;
    }

    public override string ToString(){
        return $"{Title} by {Artist} ({Genre}) {Length} min"; 
    }

}

