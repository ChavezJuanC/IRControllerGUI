# IRControllerGUI

**IRControllerGUI** is a project that lets you control your Windows PC using an **IR remote**, an **Arduino**, and an **IR receiver**.  
The circuit is simple to build and can be found inside the **/circuit** folder.  

This project uses **Windows Forms** for the GUI, **user32.dll** for Windows interactions, and **Virtual-Key Codes** to simulate media key presses.

---

## How to Run

1. **Clone** the repository: (https://github.com/ChavezJuanC/IRControllerGUI)  
2. **Build** the circuit: see the image in *(https://github.com/ChavezJuanC/IRControllerGUI/blob/master/Circuit/Screenshot%202025-11-05%20025235.png)*  
3. **Upload** the Arduino script *(insert script path)* using the Arduino IDE or VS Code with the Arduino extension.  
4. **Open** the repo in Visual Studio 2022 and run the project.  
   - Alternatively, you can run the prebuilt executable located at *(IRControllerGUI/Arduino/ArduinoSerialPortComs.cs)*.  
5. **Open Settings** to configure the COM port (where your Arduino is connected), baud rate, and any optional file paths.  
6. **Enjoy.**

---

## Features

- Lock PC  
- Screen capture  
- Mute sound  
- Play/Pause media  
- Next track  
- Previous track  
- Launch EQ app (configurable in settings)  
- Volume down  
- Volume up  
- Launch drive management app (configurable in settings)  
- Launch game launcher (configurable in settings)  
- 10 programmable buttons to launch any app of your choice  

---

## What I Learned

I picked up quite a few things while building this project:

- **IR Technology:** I learned how infrared communication works through “invisible light” (~940 nm) that’s modulated with digital information (rapid pulses at around 38 kHz). The IR receiver detects this signal and converts it into data that can be read by a microcontroller.  
- **HEX Values:** Since the Arduino script decodes signals into hexadecimal format, I took some time to understand how hexadecimal numbers work and how to read them (A–F, 0–9).  
- **JSON Handling in Visual Studio:** I learned how Visual Studio manages JSON files for storing settings — including how to ensure a copy of the JSON file is created in the *Bin* folder when the project runs.
