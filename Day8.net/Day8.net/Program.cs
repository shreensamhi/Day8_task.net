using System;
using System.Collections.Generic;

namespace Day8.net
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("Enter your choice: 1 - Calculator with Delegate, 2 - BMI Calculator, 3 - Exit");
                    int choice = int.Parse(Console.ReadLine());

                    if (choice == 1)
                    {
                        Calculator<int> intCalculator = new Calculator<int>();
                        Console.WriteLine("Int Operations:");
                        Console.WriteLine($"Add: {intCalculator.Add(10, 5)}");
                        Console.WriteLine($"Subtract: {intCalculator.Subtract(10, 5)}");
                        Console.WriteLine($"Multiply: {intCalculator.Multiply(10, 5)}");
                        Console.WriteLine($"Divide: {intCalculator.Divide(10, 5)}");

                        Console.WriteLine("\nPress Enter to return to the main menu...");
                        Console.ReadLine();
                    }
                    else if (choice == 2)
                    {
                        BMICalculator<double> calculator = new BMICalculator<double>();

                        while (true)
                        {
                            try
                            {
                                Console.Clear();
                                Console.WriteLine("Choose an option:");
                                Console.WriteLine("1 - Calculate BMI");
                                Console.WriteLine("2 - View previous BMI calculations");
                                Console.WriteLine("3 - Exit to main menu");
                                Console.Write("Enter your choice: ");
                                int bmiChoice = int.Parse(Console.ReadLine());

                                Console.Clear();

                                if (bmiChoice == 1)
                                {
                                    Console.WriteLine("Choose unit system: 1 - Metric (m, k), 2 - Imperial (in, po)");
                                    int unitChoice = int.Parse(Console.ReadLine());

                                    double height, weight;
                                    if (unitChoice == 1)
                                    {
                                        Console.Write("Enter height in m: ");
                                        height = Convert.ToDouble(Console.ReadLine());

                                        Console.Write("Enter weight in k: ");
                                        weight = Convert.ToDouble(Console.ReadLine());
                                    }
                                    else if (unitChoice == 2)
                                    {
                                        Console.Write("Enter height in in: ");
                                        height = Convert.ToDouble(Console.ReadLine()) * 0.0254;

                                        Console.Write("Enter weight in po: ");
                                        weight = Convert.ToDouble(Console.ReadLine()) * 0.453592;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid choice. Please choose 1 or 2.");
                                        continue;
                                    }

                                    double bmi = calculator.CalculateBMI(height, weight);
                                    string category = calculator.GetBMICategory(bmi);

                                    Console.WriteLine($"Calculated BMI: {bmi:F2}");
                                    Console.WriteLine($"BMI Category: {category}");
                                }
                                else if (bmiChoice == 2)
                                {
                                    calculator.DisplayPreviousCalculations();
                                }
                                else if (bmiChoice == 3)
                                {
                                    break;
                                }

                                Console.WriteLine("\nPress Enter to continue...");
                                Console.ReadLine();
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Invalid input. Please enter numeric values for height and weight.");
                                Console.WriteLine("\nPress Enter to continue...");
                                Console.ReadLine();
                            }
                        }
                    }
                    else if (choice == 3)
                    {
                        break;
                    }
                
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value for the choice.");
                    Console.WriteLine("\nPress Enter to continue...");
                    Console.ReadLine();
                }
            }
        }
    }
}
