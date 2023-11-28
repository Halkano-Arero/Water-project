using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Water_Bill
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do {
                try
                {

                    Console.WriteLine("                                                              Welcome To Water Bill Calculator!");
                    Console.WriteLine("                                                            .......................................");
                    string name;
                    double type;
                    double amount;
                    double rate;
                    double cost;


                    Console.WriteLine("Enter The Consumer Name:");
                    name = Console.ReadLine();
                    while (true)
                    {
                    Console.WriteLine("Enter you Consumption Amount:\t");
                    amount = double.Parse(Console.ReadLine()); 
                    if (amount >= 0)
                    {
                        Console.WriteLine($"The Amount of water consumed is:{amount}");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!Check and try again");
                    }
                    }
                    try {

                        while (true)
                        {
                            Console.WriteLine("Choose Your Type Of Usage");
                            Console.WriteLine("\t1=Commercial");
                            Console.WriteLine("\t2=Industrial");
                            Console.WriteLine("\t3=domestic");
                            Console.WriteLine("Enter Your Code Type:");
                            type = double.Parse(Console.ReadLine());


                            if (type == 1)
                            {
                                rate = 25.00;
                                Console.WriteLine($"Your Bill is:\n{rate}*{amount} = {rate * amount}", rate, amount);
                                break;
                            }
                            else if (type == 2)
                            {
                                rate = 30.50;
                                Console.WriteLine($"Your Bill is:\n{rate}*{amount} = {rate * amount}", rate, amount);
                                break;
                            }
                            else if (type == 3)
                            {
                                rate = 35.75;
                                Console.WriteLine($"Your Bill is:\n{rate}*{amount} = {rate * amount}", rate, amount);
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid Input! Check And Try Again!");
                            }
                        }
                    }
                    catch(FormatException)
                    {
                        Console.WriteLine("\tInvalid Code!");
                    }

                    Console.ReadKey();
                }
                catch (FormatException)
                {
                    Console.WriteLine("\tInvalid input!");
                }

                Console.WriteLine("Do you want to continue?(Y=yes,N=no):");
            }
            while (Console.ReadLine().ToUpper() == "Y");
            Console.WriteLine("Bye!");

            Console.ReadKey(true);
        }
    }
}
