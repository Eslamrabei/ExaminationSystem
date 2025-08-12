# Examination System – C# Console Application

## Overview
This project is a **Console-based Examination System** developed in C# using Object-Oriented Programming (OOP) principles.  
It allows creating and managing different types of exams, questions, and evaluating students' answers.

The project demonstrates:
- **OOP Concepts**: Inheritance, Interfaces, Constructor Chaining, Method Overriding.
- **Data Structures**: Arrays, Lists, Dictionaries.
- **Clean Code Practices**: Separation of concerns, reusability, maintainability.

---

## Features
- Create different types of exams (e.g., Practical, Final).
- Support for **MCQ** and **True/False** questions.
- Automatic grading and score calculation.
- User-friendly console interface.
- Extensible architecture for adding new exam types.

---

## Technologies Used
- **C#** (.NET 8 / .NET Framework)
- LINQ
- OOP Principles

---

## How to Run
1. Clone the repository:
   ```bash
   git clone https://github.com/Eslamrabei/ExaminationSystem.git
2. Open the solution file (.sln) in Visual Studio.
3. Set the startup project to the ExaminationSystem project.
4. Run the application (Ctrl + F5).
## Example Output
Welcome to the Examination System
Enter exam type: 1 for Practical, 2 for Final
[Sample Questions Displayed Here]
Exam Completed!
Your Score: 8 / 10


ExaminationSystem/
│
├── ExaminationSystem.sln          # Solution file
│
├── ExaminationSystem/              # Main project folder
│   ├── Program.cs                  # Entry point
│   ├── Models/                     # Classes for Questions, Exams
│   ├── Interfaces/                 # Interfaces for abstraction
│   ├── Utils/                      # Helper classes
│   └── Properties/                 # Project settings
│
├── README.md                       # Project documentation
└── .gitignore                      # Ignore unnecessary files

