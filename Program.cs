using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.VisualBasic;
class Destinations
{
    public string Destination { get; set; }
    public int Year {get ; set ; }
    public int Stars {get ; set ; }
    public string Description { get ; set ;}
    public Destinations(string destination , int year , int stars , string description)
    {
        Destination = destination;
        Year= year;
        Stars = stars;
        Description = description;
    }
}

class TravelLog
{
    public List<Destinations> travels;

    public TravelLog()
    {
        travels = new List<Destinations>();
    }
    public void AddDestination(Destinations destination)
    {
        travels.Add(destination);
    }
}

class Program
{
    static void Main(string[] args)
    {
        TravelLog travelLog = new TravelLog();
        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Add destination");
            Console.WriteLine("2. Remove destination");
            Console.WriteLine("3. Display all destinations");
            Console.WriteLine("4. Clear travel log");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Write the destination you want to record please :");
                    string Des = Console.ReadLine();
                    int year = Convert.ToInt32(Console.ReadLine());
                    int stars = Convert.ToInt32(Console.ReadLine());
                    string description = Console.ReadLine();
                    Destinations newdestination = new Destinations(Des , year , stars , description);
                    travelLog.AddDestination(newdestination);
                    Console.WriteLine("Destination was added");
                    break;
                case "2":
                    Console.WriteLine("Write the name of the destination you would like to remove :");
                    string ch = Console.ReadLine();
                    for(int i = 0 ; i < travelLog.travels.Count ; i++ )
                    {
                       Destinations destination = travelLog.travels[i];
                       if (ch == destination.Destination )
                       {
                            travelLog.travels.RemoveAt(i);
                       } 
                    }
                    break;
                case "3":
                    Console.WriteLine("here's the list as is");
                    foreach(Destinations place in travelLog.travels)
                    {
                        Console.WriteLine(place.Destination);
                    }
                    break;
                case "4":
                    
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}