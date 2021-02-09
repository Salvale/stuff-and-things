using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spikesspikesspikesspikesspikes
{
    static class Global
    {
        //Declare global variables
        public static int posit;
        public static int bananas = 0;
        public static int shells = 0;
        public static int stars= 0;
        public static int shrooms = 0;
        public static int bills = 0;
        public static System.Random random = new System.Random();
        public static string functn = "Try it!";
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Call tha big function from main because idk what that string[] args is about so I'm scared of calling main
            Global.posit = 12;
            GetInput();
        }
        //The big one that prints everything
        static void GetInput()
        {
            Console.WriteLine("Welcome to supa maaarioh kart 12409!");
            Console.WriteLine("Your current position in the race is: " + Global.posit);
            Console.WriteLine("Enter a number from 1-7 to perform a command.");
            Console.WriteLine("1: Change position");
            Console.WriteLine("2: Get an item box");
            Console.WriteLine("3: Get a custom amount of item boxes");
            Console.WriteLine("4: Get item boxes until you have 10 more bullet bills");
            Console.WriteLine("5: Display your total items");
            Console.WriteLine("6: Reset your items");
            Console.WriteLine("7: die");
            //print "functn:" a global variable that is defined at the end of each command to reflect what happened
            Console.WriteLine(Global.functn);
            //Get input from user and call the function that scans the input
            int Input = Convert.ToInt32(Console.ReadLine());
            DoIt(Input);
        }
        static void DoIt(int Input)
        { // scan input
            if (Input == 1)
            { //Get another input to change position
                Console.Write("What position in the race would you like to move to? ");
                int pos = Convert.ToInt32(Console.ReadLine());
                //If input is greater than 12 or less than 1, default to 12
                if (pos > 12 || pos < 1)
                {
                    pos = 12;
                }
                //change global position variable
                Global.posit= pos;
                Global.functn = "You have changed position";
            } else if (Input == 2) {
                // call "roll" function to randomly get item box
                Global.functn = "You got " + Roll() + " " + totals();
            } else if (Input == 3)
            { //Get input "x"
                Console.Write("How many item boxes do you want? ");
                int times = Convert.ToInt32(Console.ReadLine());
                //Get box "x" amount of times
                for (int i = 0; i < times; i++)
                {
                    Roll();
                }
                Global.functn = "Got " + times + " item boxes. " + totals();
            } else if (Input == 4)
            {
                //Declare a new "bullet bill amount" isolated from the pre-existing one
                int billy = 0;
                //Create a list to display individual item box results
                List<string> results = new List<string>();
                //Continue loop as long as there are less than 10 "new bills"
                while (billy < 10)
                {
                    string rolled = Roll();
                    results.Add(rolled);
                    if (rolled == "a bullet bill")
                    {
                        //push the new bill amount up when you get one
                        billy++;
                    }
                }
                //Stringify the aforementioned list for easy printing
                string isecretlyhatecsharp = String.Join(", ", results);
                Global.functn = "Got item boxes until 10 more bullet bills! " + totals() + " In order, you got: " + isecretlyhatecsharp;
            } else if (Input == 5)
            {
                //print totals
                Global.functn = totals();
            } else if (Input == 6)
            {
                //reset totals to 0
                Global.bananas = 0;
                Global.bills = 0;
                Global.shells = 0;
                Global.shrooms = 0;
                Global.stars = 0;
                Global.functn = "Total items reset!";
            } else if (Input == 7)
            {
                //die
                System.Environment.Exit(0);
            } else
            {
                Global.functn = "Not a valid prompt";
            }
            Console.Clear();
            GetInput();
        }
        static string Roll()
        {
            // Get random number
            int numbr = Global.random.Next(100);
            //Probabilities if you're up ahead in the race
            if (Global.posit < 7)
            {
                Console.WriteLine(numbr);
                if (numbr < 45)
                {
                    Global.bananas++;
                    return "a banana";
                } else if (numbr < 80)
                {
                    Global.shells++;
                    return "a green shell";
                } else if (numbr < 95)
                {
                    Global.stars++;
                    return "a star";
                } else if (numbr < 99)
                {
                    Global.shrooms++;
                    return "a golden mushroom";
                } else
                {
                    Global.bills++;
                    return "a bullet bill";
                }
            } else //Probabilities if you're far back
            {
                Console.WriteLine(numbr);
                if (numbr < 5)
                {
                    Global.bananas++;
                    return "a banana";
                }
                else if (numbr < 10)
                {
                    Global.shells++;
                    return "a green shell";
                }
                else if (numbr < 35)
                {
                    Global.stars++;
                    return "a star";
                }
                else if (numbr < 70)
                {
                    Global.shrooms++;
                    return "a golden mushroom";
                }
                else
                {
                    Global.bills++;
                    return "a bullet bill";
                }
            }
        }
        static string totals()
        { //Get totals in a nice neat little string
            return "You have " + Global.bananas + " bananas, " + Global.shells + " shells, " + Global.stars + " stars, " + Global.shrooms + " mushrooms, and " + Global.bills + " bullet bills.";
        }
    }
}