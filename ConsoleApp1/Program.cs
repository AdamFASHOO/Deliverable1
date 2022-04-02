using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool restart = false;
            while (!restart) 
            {
                do
                {
                    Console.Write("How many people are we making PB&J sandwiches for? ");

                    int people = int.Parse(Console.ReadLine());

                    double totalSlicesNeeded = (people * 2);
                    double slicesPerLoaf = 28;
                    double totalLoavesNeeded = (totalSlicesNeeded / slicesPerLoaf);


                    double totalTSPBNeeded = (people * 2);
                    double TSPBPerJar = 32;
                    double totalPBJarNeeded = (totalTSPBNeeded / TSPBPerJar);


                    double totalTSJNeeded = (people * 4);
                    double TSJPerJar = 48;
                    double totalJJarNeeded = (totalTSJNeeded / TSJPerJar);

                    if (people == 1)
                    {
                        Console.WriteLine(people + " person huh?");
                    }
                    else
                    Console.WriteLine(people + " people huh?");

                    Console.WriteLine("\nYou need: \n\n\t" + totalSlicesNeeded + " slices of bread.\n\t" + totalTSPBNeeded + " tablespoons of peanut butter.\n\t" + totalTSJNeeded + " tablespoons of jelly.");
                    Console.WriteLine("\n\twhich is... \n" + "\n\t" + Math.Ceiling(totalLoavesNeeded) + " loaves of bread,\n\t" + Math.Ceiling(totalPBJarNeeded) + " jars of peanut butter\n\t" + Math.Ceiling(totalJJarNeeded) + " jars of jelly");

                    Console.WriteLine("\nWould you like to restart? Enter yes or y to continue, or enter any other key to exit. ");
                    string input = Console.ReadLine().ToUpper();
                    if (input == "Y")
                    {
                        continue;
                    }
                    else if (input == "YES")
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("\nGoodbye!");
                        break;
                    }
                    
                }
                while (true);
                break;

            }
                 
                /*
            
                1 sandwich = 2 slices/bread, 2 tablespoons/peanut butter, and 4 teaspoons/jelly
            
                1 sandwich per person
                1 loaf of bread = 28 slices
                1 jar of peanut butter = 32 tablespoons
                1 jar of jelly = 48 teaspoons

                */
        }
    }
}
