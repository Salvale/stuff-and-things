using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtisticLeadSocks
{
    class Program
    {
        static void Main(string[] args)
        {
            //funnily enough, functions seem to be a far more advanced concept than arrays in c#. So I'll take the easy way out.
            try
            {


                //Create the array
                Console.WriteLine("Array Visualizer: C# edition");
                int Min = 0;
                int Max = 10;
                int arraylength = 9;
                int[] test2 = new int[arraylength];
                Random randNum = new Random();
                for (int i = 0; i < test2.Length; i++)
                {
                    //Create and draw the array values
                    int numb = i + 1;
                    test2[i] = randNum.Next(Min, Max);
                    Console.Write("Value " + numb + ": ");
                    //Draw the 0s that represent the array  
                    for (int o = 0; o < test2[i]; o++)
                    {
                        Console.Write("0");
                    }
                    Console.WriteLine("");
                }
                //Analyze array
                Console.WriteLine("Value of nine present?" + checknine(test2));
                Console.WriteLine("Value of zero present?" + checkzero(test2));//co.d.doris@gmail.com
                Console.WriteLine("Lowest value:" + lowest(test2));
                Console.WriteLine("Highest value:" + highest(test2));
                //Get user input for command
                Console.Write("Enter a Number (1-6) to perform a command ");
                int thog;
                thog = Convert.ToInt32(Console.ReadLine());
                if (thog == 1)
                {
                    Console.Clear();// subtract 1 from all values
                    Console.WriteLine("Array Visualizer: C# edition");
                    for (int i = 0; i < test2.Length; i++)
                    {
                        test2[i]--;
                        int numb = i + 1;
                        Console.Write("Value " + numb + ": ");
                        for (int o = 0; o < test2[i]; o++)
                        {
                            Console.Write("0");
                        }
                        Console.WriteLine("");
                    }
                    Console.Write("Subtracted one from all values.");
                }
                else if (thog == 2)
                {
                    Console.Clear(); // add 1 to all values 
                    Console.WriteLine("Array Visualizer: C# edition");
                    for (int i = 0; i < test2.Length; i++)
                    {
                        test2[i]++;
                        int numb = i + 1;
                        Console.Write("Value " + numb + ": ");
                        for (int o = 0; o < test2[i]; o++)
                        {
                            Console.Write("0");
                        }
                        Console.WriteLine("");
                    }
                    Console.WriteLine("Added one to all values");
                }
                else if (thog == 3)
                {
                    Console.Clear();//random value to 20
                    Console.WriteLine("Array Visualizer: C# edition");
                    test2[randNum.Next(Min, Max)] = 20;
                    for (int i = 0; i < test2.Length; i++)
                    {
                        int numb = i + 1;
                        Console.Write("Value " + numb + ": ");
                        for (int o = 0; o < test2[i]; o++)
                        {
                            Console.Write("0");
                        }
                        Console.WriteLine("");
                    }
                    Console.Write("A random value has been set to 20."); 
                }
                else if (thog == 4)
                {
                    Console.Clear();//random value to 0
                    Console.WriteLine("Array Visualizer: C# edition");
                    test2[randNum.Next(Min, Max)] = 0;
                    for (int i = 0; i < test2.Length; i++)
                    {
                        int numb = i + 1;
                        Console.Write("Value " + numb + ": ");
                        for (int o = 0; o < test2[i]; o++)
                        {
                            Console.Write("0");
                        }
                        Console.WriteLine("");
                    }
                    Console.Write("A random value has been set to 0. Note: there is a slight chance that the program may have selected a value that was already equal to zero.");
                }
                else if (thog == 5) 
                {
                    Console.Clear(); // change minimum value
                    Console.WriteLine("Array Visualizer: C# edition");
                    Console.Write("Enter a new minimum value, all values below the minimum will not be displayed: ");
                    int see = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < test2.Length; i++)
                    {
                        if (test2[i] > see)
                        {
                            int numb = i + 1;
                            Console.Write("Value " + numb + ": ");
                            for (int o = 0; o < test2[i]; o++)
                            {
                                Console.Write("0");
                            }
                            Console.WriteLine("");
                        }
                    }
                } else if (thog == 6)
                {
                    Console.Clear(); // change array length
                    Console.WriteLine("Array Visualizer: C# edition");
                    Console.Write("Change the array length to how many values?: ");
                    int longth = Convert.ToInt32(Console.ReadLine());
                    if (longth == 9)
                    {
                        for (int i = 0; i < test2.Length; i++)
                        {
                            int numb = i + 1;
                            Console.Write("Value " + numb + ": ");
                            for (int o = 0; o < test2[i]; o++)
                            {
                                Console.Write("0");
                            }
                            Console.WriteLine("");
                        }
                        Console.Write("And... Nothing Happened");
                    }
                    else if (longth < test2.Length)
                    {
                        for (int i = 0; i < longth; i++)
                        {
                            int numb = i + 1;
                            Console.Write("Value " + numb + ": ");
                            for (int o = 0; o < test2[i]; o++)
                            {
                                Console.Write("0");
                            }
                            Console.WriteLine("");
                        }
                    }
                    else if (longth > test2.Length)
                    {
                        int[] test3 = new int[longth];
                        for (int i = 0; i < test3.Length; i++)
                        {
                            //Create and draw the array values
                            int numb = i + 1;
                            test3[i] = randNum.Next(Min, Max);
                            Console.Write("Value " + numb + ": ");
                            //Draw the 0s that represent the array  
                            for (int o = 0; o < test3[i]; o++)
                            {
                                Console.Write("0");
                            }
                            Console.WriteLine("");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Command does not exist");
                }
                Console.Write(" Restart the program to try a different function!");
                Console.ReadLine();



            } catch (Exception e)
            {
                Console.WriteLine("Error " + e + " You think you're funny, do you?");
            }
            }
        //Find highest value
        static int highest(int[] array) 
        {
            int highest = -5000;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > highest)
                {
                    highest = array[i];
                }
            }
            return highest;
        }
        //Find lowest value
        static int lowest(int[] array)
        {
            int lowest = 5000;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < lowest)
                {
                    lowest = array[i];
                } 
            }
            return lowest;
        }
        //Check if nine is present
        static bool checknine(int[] array)
        {
            bool isnine = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 9)
                {
                    isnine = true;
                   break;
                 
                }
                else
                {
                    isnine = false;
                }
            }
            return isnine;
        }
        //Check if zero is present
        static bool checkzero(int[] array)
        {
            bool iszero = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <= 0)
                {
                    iszero = true;
                    break;

                }
                else
                {
                    iszero = false;
                }

            }
            return iszero;
        }
    }
}