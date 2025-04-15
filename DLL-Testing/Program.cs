using AstroMath; // Import AstroMath DLL

/// <summary>
/// This program is designed to test the functionality of the AstroMath.dll library.
/// It provides options to test various astronomical calculations such as:
/// - Temperature conversion (Celsius to Kelvin)
/// - Star velocity calculation
/// - Star distance calculation
/// - Event horizon calculation
/// </summary>
internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("AstroMath DLL Testing Program");
        Console.WriteLine("Choose an option to test:");
        Console.WriteLine("1. Convert Celsius to Kelvin");
        Console.WriteLine("2. Calculate Star Velocity");
        Console.WriteLine("3. Calculate Star Distance");
        Console.WriteLine("4. Calculate Event Horizon");
        Console.Write("Enter your choice (1-4): ");

        string? input = Console.ReadLine();
        string choice = input ?? string.Empty; // Handle null input

        switch (choice)
        {
            case "1":
                TestTempConversion();
                break;
            case "2":
                TestStarVelocity();
                break;
            case "3":
                TestStarDistance();
                break;
            case "4":
                TestEventHorizon();
                break;
            default:
                Console.WriteLine("Invalid choice. Please restart the program and choose a valid option.");
                break;
        }
    }

    /// <summary>
    /// Tests the temperature conversion functionality of the AstroMath library.
    /// Converts a temperature from Celsius to Kelvin.
    /// </summary>
    private static void TestTempConversion()
    {
        Console.Write("Enter a temperature in Celsius to convert to Kelvin: ");
        if (double.TryParse(Console.ReadLine(), out double celsiusInput))
        {
            double kelvin = AstroMathFunctions.tempConversion(tempInCelsius: celsiusInput);
            Console.WriteLine($"The temperature in Kelvin is: {kelvin}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }
    }

    /// <summary>
    /// Tests the star velocity calculation functionality of the AstroMath library.
    /// Calculates the velocity of a star based on observed and rest wavelengths.
    /// </summary>
    private static void TestStarVelocity()
    {
        Console.Write("Enter the observed wavelength: ");
        if (double.TryParse(Console.ReadLine(), out double observedWavelength))
        {
            Console.Write("Enter the rest wavelength: ");
            if (double.TryParse(Console.ReadLine(), out double restWavelength))
            {
                AstroMathFunctions astroMath = new AstroMathFunctions(); // Create an instance
                double velocity = astroMath.measureVolicity(observedWaveLength: observedWavelength, restWaveLength: restWavelength);
                Console.WriteLine($"The star velocity is: {velocity}");
            }
            else
            {
                Console.WriteLine("Invalid input for rest wavelength. Please enter a numeric value.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input for observed wavelength. Please enter a numeric value.");
        }
    }

    /// <summary>
    /// Tests the star distance calculation functionality of the AstroMath library.
    /// Calculates the distance to a star based on an angle in arcseconds.
    /// </summary>
    private static void TestStarDistance()
    {
        Console.Write("Enter the angle in arcseconds: ");
        if (double.TryParse(Console.ReadLine(), out double angle))
        {
            AstroMathFunctions astroMath = new AstroMathFunctions(); // Create an instance
            double distance = astroMath.calculateStarDistance(arcSecondsAngle: angle);
            Console.WriteLine($"The star distance is: {distance}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }
    }

    /// <summary>
    /// Tests the event horizon calculation functionality of the AstroMath library.
    /// Calculates the event horizon of a black hole based on its mass.
    /// </summary>
    private static void TestEventHorizon()
    {
        Console.Write("Enter the black hole mass: ");
        if (double.TryParse(Console.ReadLine(), out double blackHoleMass))
        {
            double eventHorizon = AstroMathFunctions.calculateEventHorizon(blackHoleMass: blackHoleMass);
            Console.WriteLine($"The event horizon is: {eventHorizon}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }
    }
}