using System;

class MainClass {
  public static void Main (string[] args) {
    
    Artist a1 = new Artist("Taylor Swift");
    Console.WriteLine(a1.fname + " " + a1.lname + " " + a1.email);


    Song s1 = new Song("Talor Swift", "Love story");
    Song s2 = new Song("Talor Swift", "Girl at Home");
    Song s3 = new Song("Talor Swift", "The moment I knew ");
    Console.WriteLine(s1.id + " " + s1.title + " "); 
    Console.WriteLine(s2.id + " " + s2.title + " "); 
    Console.WriteLine(s3.id + " " + s3.title + " ");

    s1.Display();
    s2.Display();
    s3.Display();
    a1.Display();
  }
}