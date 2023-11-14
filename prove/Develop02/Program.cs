using System;
using System.Runtime.InteropServices;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        while (true)
        {


            
            Console.WriteLine("Welcome to the Journal program\n"+
                "1) Add Entry\n"+
                "2) Display Entries\n"+
                "3) Save\n"+
                "4) Load\n"+
                "5) Quit\n"+
                "\n");
                
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    journal.AddEntry();
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.WriteLine("Enter file name: ");
                    string file = Console.ReadLine();
                    journal.SaveToFile(file);
                    break;
                case "4":
                    Console.WriteLine("Enter file name: ");
                    file = Console.ReadLine();
                    journal.LoadFromFile(file);
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}