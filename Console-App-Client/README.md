# UpdatedConsoleAppClient

## Overview
The `ConsoleAppClient` is a console-based application that acts as a client for the `ConsoleAppServer`, a WCF (Windows Communication Foundation) service. This client allows users to perform various astronomical calculations by interacting with the server. The server performs the computations using the `AstroMath.dll` library and returns the results to the client.

This project is part of a WCF project (Windows Communication Foundation) that includes:
- The `ConsoleAppServer`, which hosts the WCF service.
- The `AstroMath.dll` library, which provides the core astronomical calculation functions.

## Features
The client provides the following functionalities:
1. **Temperature Conversion**  
   Converts a temperature from Celsius to Kelvin.
   
2. **Star Velocity Calculation**  
   Calculates the velocity of a star based on its observed and rest wavelengths.
   
3. **Star Distance Calculation**  
   Determines the distance to a star based on its angular size in arcseconds.
   
4. **Event Horizon Calculation**  
   Computes the radius of the event horizon of a black hole based on its mass.

## Architecture
The `ConsoleAppClient` communicates with the `ConsoleAppServer` using WCF. It uses the `IAstroContract` interface to define the operations exposed by the server. The client sends user inputs to the server, which performs the calculations and returns the results.

### Key Components
- **Service Contract**: The `IAstroContract` interface defines the operations available to the client.
- **Communication Binding**: The client uses `NetNamedPipeBinding` for fast and secure communication with the server on the same machine.
- **User Interface**: A console-based menu allows users to select operations and input data.

## How to Run
### Prerequisites
- .NET Framework 4.8
- Visual Studio 2019 or later
- The `ConsoleAppServer` must be running and listening for requests at `net.pipe://localhost/AstroServer`.

### Steps
1. **Start the Server**  
   - Open the `ConsoleAppServer` solution in Visual Studio.
   - Build and run the project. The server will start and listen for client requests.

2. **Run the Client**  
   - Open the `ConsoleAppClient` solution in Visual Studio.
   - Build and run the project. The client will display a menu in the console.

3. **Perform Calculations**  
   - Select an option from the menu (1-4) to perform a calculation.
   - Provide the required inputs when prompted.
   - View the results displayed in the console.

## Example Usage
### Temperature Conversion
1. Select option `1` from the menu.
2. Enter a temperature in Celsius (e.g., `25`).
3. The client sends the input to the server, which converts it to Kelvin and returns the result.
4. The result is displayed in the console.

### Star Velocity Calculation
1. Select option `2` from the menu.
2. Enter the observed wavelength and rest wavelength of the star.
3. The server calculates the velocity and returns the result.
4. The result is displayed in the console.

### Star Distance Calculation
1. Select option `3` from the menu.
2. Enter the angular size of the star in arcseconds.
3. The server computes the distance and returns the result.
4. The result is displayed in the console.

### Event Horizon Calculation
1. Select option `4` from the menu.
2. Enter the mass of the black hole.
3. The server calculates the event horizon radius and returns the result.
4. The result is displayed in the console.

## Screenshots
### Client Running
![Client Running](https://i.imgur.com/hOnkqDD.png)

### Example Output
![Example Output](https://i.imgur.com/ypGiiji.png)

## Notes
- Ensure the `ConsoleAppServer` is running before starting the client.
- The client and server must be on the same machine to use `NetNamedPipeBinding`.
- This project is for educational purposes and is not intended for production use.

## License
This project is for educational purposes only and is not licensed for commercial use.

## Author
This project was developed as part of the ICT50220 Diploma of Information Technology (Advanced Programming) coursework at TAFE.