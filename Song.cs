using System;

class Song
{
  public int Id.Length {get;set;}
  public string Title.Text {get;set;}
  public string ArtistInfo {get;set;}
}


public Song()
{
    Id = 1234;
    Title = "unknown";
    Artistinfo = "unknown";
    }

public Song(int id, string title)
{
  Id = id;
  Title = title;

}

 public static void AddArtistInfo(Artist){
  //Artist = Artist;
  Console.WriteLine(Artist);

}

public void Display(){

    Console.WriteLine(id + "," + "," + title + " , "+ ArtistInfo);
    
    }
}