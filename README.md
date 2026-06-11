# Bird Aviary Management System

A C# Windows Forms desktop application for managing bird records in an aviary inventory.

The system allows users to add birds manually, validate input, generate random bird records, display data in a table, sort birds by hatch year, and generate an inventory report.

## Screenshot

![Main Screen](screenshots/Dashboard.png)

## Technologies Used

* C#
* .NET Framework
* Windows Forms
* MSTest
* Git & GitHub

## Main Features

* Add new bird records manually
* Validate user input before adding data
* Display all birds in an inventory table
* Generate 10,000 random bird records
* Sort birds by hatch year using QuickSort
* Compare sorting logic with Bubble Sort implementation
* Generate an inventory report
* Calculate average bird age
* Count birds available for sale
* View bird details by double-clicking a table row
* Unit tests for core logic

## Input Validation

The system validates the following fields:

* Ring ID must contain numbers only
* Ring ID must be unique
* Color mutation must contain letters only
* Hatch year must be between 1900 and 2026
* Bird type, status, and sale availability must be selected

## Inventory Report

The report includes:

* Total number of birds
* Average bird age
* Number of birds available for sale
* QuickSort execution time

## Testing

The project includes a separate MSTest project for testing core logic.

Tested functionality includes:

* Sorting birds by hatch year
* Calculating average bird age
* Counting birds available for sale
* Updating bird availability using a health service

## Project Structure

```text
BirdAviaryManagement
│
├── birdAviarymanagement
│   ├── Bird.cs
│   ├── Form1.cs
│   ├── Form1.Designer.cs
│   ├── HealthService.cs
│   ├── IHealthService.cs
│   ├── Program.cs
│   └── Resources
│
├── TestProject2
│   ├── BirdAviaryManagementTests.cs
│   └── TestProject2.csproj
│
├── BirdAviaryManagement.slnx
├── .gitignore
└── README.md
```

## Core Classes

### Bird

Represents a bird record in the aviary system.

Main properties:

* RingId
* Type
* ColorMutation
* HatchYear
* Status
* AvailableForSale

### Form1

The main Windows Forms interface.

Responsible for:

* User interaction
* Input validation
* Displaying bird data
* Updating the inventory table
* Generating reports
* Styling the UI

### IHealthService

Defines a health-check service interface.

### HealthService

Implements bird health-check logic used to update sale availability.

## How to Run

1. Clone the repository:

```bash
git clone https://github.com/yahav11/BirdAviaryManagement.git
```

2. Open the solution in Visual Studio.

3. Build the solution.

4. Run the WinForms project.

## How to Run Tests

1. Open the solution in Visual Studio.
2. Open Test Explorer.
3. Run all tests.

## Notes

This project was created as an academic Windows Forms project.
The main focus is on data management, input validation, sorting algorithms, reporting logic, UI design, and unit testing.

## Authors

Developed by Yahav Gueta & Tehila Atedgi
