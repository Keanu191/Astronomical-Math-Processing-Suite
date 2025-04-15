# Astronomical-Math-Processing-Suite

Astronomical-Math-Processing-Suite is a comprehensive solution for astronomical calculations, consisting of multiple interconnected components. It includes a **Main Application** (Windows Forms app), a **Console-Based Server**, a **Console-Based Client**, and a **DLL Testing Program**. These components work together to provide a robust system for performing astronomical computations, testing functionality, and showcasing advanced programming techniques.

---

## **Workspace Structure**

### **1. Main Application**
- **Purpose**: Provides a graphical user interface (GUI) for interacting with the WCF server and performing astronomical calculations.
- **Key Features**:
  - Perform calculations such as temperature conversion, star velocity, star distance, and event horizon radius.
  - Test the connection to the WCF server.
  - Customize the UI with dark mode, color changes, and font changes.
  - Multilingual support (English, French, German).
- **Screenshot Placeholders**:
  - **Dark Mode**:  
    ![Dark Mode](https://i.imgur.com/5SjF1KJ.png)
  - **Color Dialog**:  
    ![Color Dialog](https://i.imgur.com/kN5UdV3.png)
  - **Font Dialog**:  
    ![Font Dialog](https://i.imgur.com/aFoPlD4.png)
  - **Language Change**:  
    ![Language Change](https://i.imgur.com/wUn6iqn.png)
  - **Calculations**:  
    ![Calculations](https://i.imgur.com/3Fum7TJ.png)
  - **Connection Test**:  
    ![Connection Test](https://i.imgur.com/YyrvFuW.png)

### **2. Console-App-Server**
- **Purpose**: Hosts the WCF service that performs astronomical calculations.
- **Key Features**:
  - Implements the `IAstroContract` interface to expose operations.
  - Uses the `AstroMath.dll` library for computations.
  - Communicates with the Main Application and Console-App-Client.

### **3. Console-App-Client**
- **Purpose**: A console-based client for interacting with the WCF server.
- **Key Features**:
  - Sends requests to the WCF server and displays responses in the console.
  - Useful for testing and debugging the server.

### **4. DLL-Testing**
- **Purpose**: A console-based program for testing the functionality of the `AstroMath.dll` library.
- **Key Features**:
  - Validates the correctness of the library's methods.
  - Provides a menu-driven interface for testing calculations.

---

## **How the Components Work Together**
1. **Main Application**: Acts as the front-end, allowing users to interact with the WCF server via a GUI.
2. **Console-App-Server**: Hosts the WCF service and performs calculations using `AstroMath.dll`.
3. **Console-App-Client**: Provides a console-based interface for interacting with the WCF server.
4. **DLL-Testing**: Tests the functionality of the `AstroMath.dll` library in isolation.

---

## **How to Run the Workspace**
1. **Start the WCF Server**:
   - Open the `Console-App-Server` project in Visual Studio.
   - Build and run the project to start the server.

2. **Run the Main Application**:
   - Open the `Main-Application` project in Visual Studio.
   - Build and run the project to use the GUI.

3. **Run the Console-App-Client** (Optional):
   - Open the `Console-App-Client` project in Visual Studio.
   - Build and run the project to interact with the server via the console.

4. **Run the DLL-Testing Program** (Optional):
   - Open the `DLL-Testing` project in Visual Studio.
   - Build and run the project to test the `AstroMath.dll` library.

---

