using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace UpdatedConsoleAppClient
{
    /// <summary>
    /// Entry point for the UpdatedConsoleAppClient application.
    /// Provides a console-based interface to interact with the AstroServer WCF service.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main method to run the console application.
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        static void Main(string[] args)
        {
            string address = "net.pipe://localhost/AstroServer"; // WCF service endpoint
            NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
            EndpointAddress ep = new EndpointAddress(address);
            IAstroContract channel = ChannelFactory<IAstroContract>.CreateChannel(binding, ep); // Create WCF channel

            Console.WriteLine("Welcome to the console server application!");
            Console.WriteLine("1: Temperature Conversion (Celsius to Kelvin)");
            Console.WriteLine("2: Star Velocity");
            Console.WriteLine("3: Star Distance");
            Console.WriteLine("4: Event Horizon");
            Console.WriteLine("5: Type Exit to quit");
            Console.WriteLine("Please choose an option from 1 - 5:");

            bool loop = true;

            while (loop)
            {
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        CelsiusToKelvin(channel);
                        break;
                    case "2":
                        StarVelocity(channel);
                        break;
                    case "3":
                        StarDistance(channel);
                        break;
                    case "4":
                        EventHorizon(channel);
                        break;
                    case "Exit":
                        loop = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please select a valid option:");
                        break;
                }

                if (loop)
                {
                    Console.WriteLine("Please select another option or type Exit to quit:");
                }
            }
        }

        /// <summary>
        /// Converts a temperature from Celsius to Kelvin using the WCF service.
        /// </summary>
        /// <param name="channel">The WCF service channel.</param>
        static void CelsiusToKelvin(IAstroContract channel)
        {
            try
            {
                Console.WriteLine("Enter a temperature in degrees Celsius:");
                if (double.TryParse(Console.ReadLine(), out double value))
                {
                    double result = channel.tempConversion(value);
                    Console.WriteLine($"Temperature in Kelvin: {result} K");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }

        /// <summary>
        /// Calculates the velocity of a star based on observed and rest wavelengths.
        /// </summary>
        /// <param name="channel">The WCF service channel.</param>
        static void StarVelocity(IAstroContract channel)
        {
            try
            {
                Console.WriteLine("Enter observed wavelength:");
                if (double.TryParse(Console.ReadLine(), out double observedWavelength))
                {
                    Console.WriteLine("Enter rest wavelength:");
                    if (double.TryParse(Console.ReadLine(), out double restWavelength))
                    {
                        double result = channel.measureVelocity(observedWavelength, restWavelength);
                        Console.WriteLine($"Star velocity: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for rest wavelength. Please enter a valid number.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input for observed wavelength. Please enter a valid number.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }

        /// <summary>
        /// Calculates the distance to a star based on its angular size in arcseconds.
        /// </summary>
        /// <param name="channel">The WCF service channel.</param>
        static void StarDistance(IAstroContract channel)
        {
            try
            {
                Console.WriteLine("Enter angle in arcseconds:");
                if (double.TryParse(Console.ReadLine(), out double arcSecondsAngle))
                {
                    double result = channel.calculateStarDistance(arcSecondsAngle);
                    Console.WriteLine($"Star distance: {result} parsecs");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }

        /// <summary>
        /// Calculates the event horizon of a black hole based on its mass.
        /// </summary>
        /// <param name="channel">The WCF service channel.</param>
        static void EventHorizon(IAstroContract channel)
        {
            try
            {
                Console.WriteLine("Enter black hole mass:");
                if (double.TryParse(Console.ReadLine(), out double blackHoleMass))
                {
                    double result = channel.calculateEventHorizon(blackHoleMass);
                    Console.WriteLine($"Event horizon: {result} meters");
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occurred: {e.Message}");
            }
        }
    }
}
