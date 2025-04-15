# UpdatedConsoleAppServer

## Overview

The `UpdatedConsoleAppServer` is a WCF (Windows Communication Foundation) service application that provides astronomical calculations as a service. It is designed to work in conjunction with an AstroClient, which is a Windows Forms application that allows users to interact with the server and perform various astromath calculations.

The server leverages the `AstroMath.dll` library to perform the actual computations and exposes these functionalities through a WCF service interface.

---

## Features

The server provides the following operations via the WCF service:

1. **Temperature Conversion**  
   Converts a temperature from Celsius to another scale.

2. **Star Velocity Measurement**  
   Calculates the velocity of a star based on its observed and rest wavelengths.

3. **Star Distance Calculation**  
   Determines the distance to a star based on its angular size in arcseconds.

4. **Event Horizon Calculation**  
   Computes the radius of the event horizon of a black hole based on its mass.

---

## Architecture

### Server (`UpdatedConsoleAppServer`)

- **Service Contract**:  
  The service contract is defined in [`IAstroContract`](UpdatedConsoleAppServer/IAstroContract.cs), which specifies the operations exposed by the server.

- **Service Implementation**:  
  The service is implemented in [`AstroServer`](UpdatedConsoleAppServer/AstroServer.cs), which uses the `AstroMathFunctions` class from the `AstroMath.dll` library to perform the calculations.

- **Hosting**:  
  The server is hosted as a console application in [`Program`](UpdatedConsoleAppServer/Program.cs). It uses a `NetNamedPipeBinding` to communicate with the client.

### Client (`AstroClient`)

The AstroClient is a Windows Forms application that acts as a front-end for the server. It allows users to input data, send requests to the server, and display the results of the calculations. The client communicates with the server using the WCF service interface.

---

## How to Run

### Prerequisites

- .NET Framework 4.8
- Visual Studio 2019 or later
- `AstroMath.dll` (included in the project)

### Steps

1. **Start the Server**:
   - Open the `UpdatedConsoleAppServer` solution in Visual Studio.
   - Build and run the project. The server will start and listen for client requests at `net.pipe://localhost/AstroServer`.

2. **Run the Client**:
   - Open the AstroClient solution (not included in this repository).
   - Build and run the client application.
   - Use the client interface to perform calculations by sending requests to the server.

---

## Example Usage

1. **Temperature Conversion**:
   - Input a temperature in Celsius in the client application.
   - The client sends the value to the server.
   - The server converts the temperature and returns the result to the client.

2. **Star Velocity Measurement**:
   - Input the observed and rest wavelengths of a star.
   - The server calculates the velocity and sends the result back to the client.

3. **Star Distance Calculation**:
   - Input the angular size of a star in arcseconds.
   - The server computes the distance and returns it to the client.

4. **Event Horizon Calculation**:
   - Input the mass of a black hole.
   - The server calculates the event horizon radius and sends it to the client.


---

## Screenshots

![Server Running Screenshot](https://i.imgur.com/9EOFTIG.png)

---

## License

This project is for educational purposes and is not licensed for commercial use.
