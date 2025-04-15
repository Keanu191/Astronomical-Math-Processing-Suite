# AstroMath DLL Testing Program

## Overview

This project is a console-based application designed to test the functionality of the `AstroMath.dll` library. The `AstroMath.dll` was provided as part of the **ICT50220 Diploma of Information Technology (Advanced Programming)** course at TAFE. The library contains various astronomical calculation functions, and this program serves as a testing tool to validate its features.

The project is part of a larger system that includes a **Windows Forms** application and a **WCF (Windows Communication Foundation)** service. This console application focuses solely on testing the DLL's functionality in isolation.

---

## Features

The program provides the following testing options:

1. **Temperature Conversion**  
   Converts a temperature from Celsius to Kelvin using the `tempConversion` method in the `AstroMath.dll`.

2. **Star Velocity Calculation**  
   Calculates the velocity of a star based on observed and rest wavelengths using the `measureVolicity` method.

3. **Star Distance Calculation**  
   Computes the distance to a star based on an angle in arcseconds using the `calculateStarDistance` method.

4. **Event Horizon Calculation**  
   Determines the event horizon of a black hole based on its mass using the `calculateEventHorizon` method.

---

## How to Use

1. **Run the Program**  
   Execute the program in a console environment. The program will display a menu with the available testing options.

2. **Choose an Option**  
   Enter the number corresponding to the test you want to perform (1-4).

3. **Provide Input**  
   Follow the prompts to input the required values for the selected test. Ensure that the inputs are numeric where applicable.

4. **View Results**  
   The program will display the calculated result based on the input provided.

---

## Prerequisites

- **.NET 8.0 SDK**  
  The project targets `.NET 8.0`. Ensure you have the appropriate SDK installed.

- **AstroMath.dll**  
  The `AstroMath.dll` file must be present in the project directory. It is referenced in the project file and is essential for the program to function.

---

## Example Output

Below is an example of the console application running:

![Console App Running](https://i.imgur.com/YTNxmBb.png)

---

## Notes

- This project is part of the **ICT50220 Diploma of Information Technology (Advanced Programming)** coursework.
- The `AstroMath.dll` was provided by TAFE and is included in this repository for program function.
- The program is designed for educational purposes and may not be suitable for production use.

---

## License

This project is for educational purposes only and is not intended for commercial use. The `AstroMath.dll` is the property of South Metropolitan TAFE and is used here as part of the coursework.

---

## Author

This project was developed as part of the **ICT50220 Diploma of Information Technology (Advanced Programming)** at TAFE.

