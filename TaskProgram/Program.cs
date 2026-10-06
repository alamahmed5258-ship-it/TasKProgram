using System.Diagnostics.CodeAnalysis;

namespace TaskProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu Options:");
            List<int> number = new List<int>();
            string choise = "";
            for (; choise != " " && choise != " ";)
            {
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("E - Count positive, negative and zero values");
                Console.WriteLine("F - Find a number");
                Console.WriteLine("Q - Quit");
                Console.WriteLine("Enter Your Choice:");
                choise = Console.ReadLine();
                switch (choise)
                {
                    case "P":
                    case "p":
                        {
                            if (number.Count == 0)
                            {
                                Console.WriteLine("[] - the list is empty");
                            }
                            else
                            {
                                Console.Write("[" + " ");
                                for (int i = 0; i < number.Count; i++)
                                {
                                    Console.Write(number[i] + " ");
                                }
                                Console.Write("]");
                            }
                            break;

                        }
                    case "A":
                    case "a":
                        {
                            Console.WriteLine("Enter an integer to add :");
                            int input = Convert.ToInt32(Console.ReadLine());
                            int matches = 0;
                            for (int i = 0; i < number.Count; i++)
                            {
                                if (input == number[i])
                                {
                                    matches++;
                                }
                            }
                            if (matches == 0)
                            {
                                number.Add(input);
                                Console.WriteLine(input + " added");
                            }
                            else
                            {
                                Console.WriteLine(input + " already exists in the list");
                            }
                            break;
                        }
                    case "M":
                    case "m":
                        {
                            int sum = 0;
                            if (number.Count == 0)
                            {
                                Console.WriteLine("[] - the list is empty");
                            }
                            else
                            {

                                for (int i = 0; i < number.Count(); i++)
                                {
                                    sum += number[i];
                                }
                            }

                            double mean = (double)sum / number.Count();
                            Console.WriteLine("Mean: " + mean);
                            break;
                        }
                    case "S":
                    case "s":
                        {
                            if (number.Count == 0)
                            {
                                Console.WriteLine("[] - the list is empty");

                            }
                            else
                            {
                                int smallest = number[0];
                                for (int i = 1; i < number.Count; i++)
                                {
                                    if (number[i] < smallest)
                                    {
                                        smallest = number[i];
                                    }
                                }

                                Console.WriteLine("Smallest number: " + smallest);
                            }

                            break;
                        }
                    case "L":
                    case "l":
                        {
                            if (number.Count == 0)
                            {
                                Console.WriteLine("[] - the list is empty");
                            }
                            else
                            {
                                int largest = number[0];
                                for (int i = 0; i < number.Count; i++)
                                {
                                    if (number[i] > largest)
                                    {
                                        largest = number[i];
                                    }
                                }
                                Console.WriteLine("Largest number: " + largest);
                            }
                            break;
                        }
                    case "E":
                    case "e":
                        {
                            int positiveCount = 0;
                            int negativeCount = 0;
                            int zeroCount = 0;

                            for (int i = 0; i < number.Count; i++)
                            {
                                if (number[i] > 0)
                                {
                                    positiveCount++;
                                }
                                else if (number[i] < 0)
                                {
                                    negativeCount++;
                                }
                                else
                                {
                                    zeroCount++;
                                }
                            }

                            Console.WriteLine("Positive numbers: " + positiveCount);
                            Console.WriteLine("Negative numbers: " + negativeCount);
                            Console.WriteLine("Zeros: " + zeroCount);

                            break;
                        }
                    case "F":
                    case "f":
                        {
                            if (number.Count() == 0)
                            {
                                Console.WriteLine("[] - the list is empty");

                            }
                            else
                            {
                                Console.WriteLine("Enter a number to find:");
                                int numFind = Convert.ToInt32(Console.ReadLine());
                                for (int i = 0; i < number.Count; i++)
                                {
                                    if (numFind == number[i])
                                    {
                                        Console.WriteLine(numFind + " found at index " + i);

                                    }


                                }


                                Console.WriteLine(numFind + " is not found in the list");

                            }
                            break;
                        }
                    case "C":
                    case "c":
                        {
                            if (number.Count() == 0)
                            {
                                Console.WriteLine("list is empty");
                            }
                            else
                            {
                                number.Clear();
                                Console.WriteLine("List cleared.");
                            }
                            break;
                        }
                    case "Q":
                        case "q":
                        {
                            Console.WriteLine("Goodbye");
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Invalid choice, please try again.");
                            break;
                        }


                }
            }
        }
    }
}
