using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8.net
{
    public class BMICalculator<T> 
    {
        private Stack<double> previousBMIs;

        public BMICalculator()
        {
            previousBMIs = new Stack<double>();
        }

        public double CalculateBMI(double height, double weight)
        {
            double heightInMeters = height;
            double weightInKilograms = weight;

            double bmi = weightInKilograms / (heightInMeters * heightInMeters);
            previousBMIs.Push(bmi);
            return bmi;
        }

        public string GetBMICategory(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                return "Normal weight";
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                return "Overweight";
            }
            else
            {
                return "Obesity";
            }
        }

        public void DisplayPreviousCalculations()
        {
            if (previousBMIs.Count == 0)
            {
                Console.WriteLine("No previous calculations.");
            }
            else
            {
                Console.WriteLine("Previous BMI calculations:");
                foreach (var bmi in previousBMIs)
                {
                    Console.WriteLine($"BMI: {bmi:F2}, Category: {GetBMICategory(bmi)}");
                }
            }
        }
    }
}
