using System;
//using Systems.Text;

class Artist
{
  public string FirstName.Text {get;set;}
  public string LastName.Text {get;set;}
  public string Email.Text {get;set;}


  public Artist(string fname, string lname)
   {
    Email = "Unknown";
    FisrtName = fname;
    LastName = lname;
   }

  public void Display(){

  Console.WriteLine("Artist Info:  " + fname + lname);
  }
}