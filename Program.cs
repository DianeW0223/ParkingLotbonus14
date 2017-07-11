using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingBonus13
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Gathering information from the user.
            bool run = true;
            
            Console.WriteLine("Welcome to the parking garage app");
            while (run == true)
            {
                Console.WriteLine("How many levels will your garage have?");
                int level = int.Parse(Console.ReadLine());
                Console.WriteLine("How many cars and motorcycles do you want to park on each level?");
                int vehicles = int.Parse(Console.ReadLine());

                //using the garage object to get the counts to display the user.
                Garage myGarage = new Garage(level, vehicles);
                int carSpace = myGarage.getSpaces(vehicles, level);
                int busSpace = myGarage.getBusSpace(vehicles, level);

                //Information displaying for the user to see.
                Console.WriteLine("Your parking garage can hold up to " + carSpace + " cars and/or motorcycles");
                Console.WriteLine("Your parking garage could possible hold up to " + busSpace + " buses, depending on the number of cars and vehicles in the garage");
                
                run = Continue();
            }
            
        }
        public static Boolean Continue()
        {
            Boolean run;
            
            Console.WriteLine("Would you like to build another garage? Y/N");
            String answer = Console.ReadLine();
            

            if ((answer == "Y") || (answer == "y"))
            {
                run = true;
                

            }
            else if ((answer == "N") || (answer == "n"))
            {
                run = false;

                Console.WriteLine("Good Bye!");
            }
            else
            {
                Console.WriteLine("I'm sorry I don't understand. Let's try again");
                run = Continue();
            }
            return run;
        }
    }
}
