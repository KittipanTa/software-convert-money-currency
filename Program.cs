using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace software_calculate_distance_from_gas
{
    
        class Vehicle
        {
            private double gasLiter;
            private const int wheelCircumference = 95;
            private const int roundsPerLiter = 13000;

            public Vehicle(double gasLiter)
            {
                this.gasLiter = gasLiter;
            }

            public double CalculateDistance()
            {
                return (gasLiter * roundsPerLiter * wheelCircumference) / 100000;
            }
        }
    class Program
    {
        
            static void Main(string[] args)
            {
            while (true)
            {
                Console.Write("Enter the amount of gas in liters:");
                string gasLiter = Console.ReadLine();
                double number;
                if (double.TryParse(gasLiter, out number) && number > 2)
                {
                    Vehicle vehicle = new Vehicle(number);
                    double distance = vehicle.CalculateDistance();
                    Console.WriteLine("Distance: " + distance + " KM");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a integer number ");
                }
                Console.WriteLine("Again y/n");
                string ck = Console.ReadLine().ToString();
                if (ck == "n")
                {
                    break;
                }
                Console.Clear();
            }
            
            
            }
        }
    
}
