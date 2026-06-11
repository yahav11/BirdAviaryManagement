# Bird Aviary Management System

A Windows Forms desktop application for managing a bird aviary inventory.  
The system allows users to add birds, validate input, generate random data, display birds in a data table, sort records by hatch year, and produce an inventory report.

## Project Overview

Bird Aviary Management System is a C# WinForms application developed as part of a software engineering course project.

The system focuses on basic inventory management for an aviary, including:

- Adding new birds to the system
- Displaying all birds in a data table
- Validating user input
- Generating 10,000 random bird records
- Sorting birds by hatch year
- Creating an inventory report
- Calculating average bird age
- Counting birds available for sale
- Viewing bird details by double-clicking a table row

## Technologies Used

- C#
- .NET Framework
- Windows Forms
- MSTest
- Git & GitHub

## Main Features

### Add Bird

Users can manually add a bird by entering:

- Ring ID
- Bird type
- Color mutation
- Hatch year
- Status
- Sale availability

The system validates the input before adding the bird.

Validation includes:

- Ring ID must contain numbers only
- Ring ID must be unique
- Color mutation must contain letters only
- Hatch year must be between 1900 and 2026
- Required ComboBox fields must be selected

### Random Data Generation

The system can generate 10,000 random bird records and display them in the data table.

A progress bar is used to visually show the generation process.

### Bird Inventory Table

All birds are displayed in a DataGridView table.

The table presents the bird data in a clean inventory-style view.

### Sorting

The system includes two sorting implementations:

- Bubble Sort
- QuickSort

The main report uses QuickSort to sort birds by hatch year in descending order.

### Inventory Report

The system generates a report that includes:

- Total number of birds
- Average bird age
- Number of birds available for sale
- QuickSort execution time

### Bird Details

Users can double-click a bird in the table to view detailed information about that bird.

## Testing

The project includes a separate MSTest project for testing core logic.

Tested areas include:

- Sorting functionality
- Average age calculation
- Counting birds available for sale
- Bird availability update logic

## Project Structure

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

## Core Classes

### Bird

Represents a bird in the aviary system.

Main properties:

- RingId
- Type
- ColorMutation
- HatchYear
- Status
- AvailableForSale

### Form1

The main Windows Forms interface.

Responsible for:

- User interaction
- Input validation
- Displaying bird data
- Updating the inventory table
- Generating reports
- Styling the UI

### IHealthService

Defines a health-check service interface.

### HealthService

Implements bird health-check logic used to update sale availability.

## Screenshots

Add screenshots of the system here.

Example:

![Main Screen](screenshots/main-screen.png)

## How to Run

1. Clone the repository:

git clone https://github.com/yahav11/BirdAviaryManagement.git

2. Open the solution in Visual Studio.

3. Build the solution.

4. Run the WinForms project.

## How to Run Tests

1. Open the solution in Visual Studio.
2. Open Test Explorer.
3. Run all tests.

## Notes

This project was created as an academic Windows Forms project.  
The main focus is on implementing basic data management, validation, sorting algorithms, reporting logic, and unit testing.

# Bird Aviary Management System

A Windows Forms desktop application for managing a bird aviary inventory.  
The system allows users to add birds, validate input, generate random data, display birds in a data table, sort records by hatch year, and produce an inventory report.

## Project Overview

Bird Aviary Management System is a C# WinForms application developed as part of a software engineering course project.

The system focuses on basic inventory management for an aviary, including:

- Adding new birds to the system
- Displaying all birds in a data table
- Validating user input
- Generating 10,000 random bird records
- Sorting birds by hatch year
- Creating an inventory report
- Calculating average bird age
- Counting birds available for sale
- Viewing bird details by double-clicking a table row

## Technologies Used

- C#
- .NET Framework
- Windows Forms
- MSTest
- Git & GitHub

## Main Features

### Add Bird

Users can manually add a bird by entering:

- Ring ID
- Bird type
- Color mutation
- Hatch year
- Status
- Sale availability

The system validates the input before adding the bird.

Validation includes:

- Ring ID must contain numbers only
- Ring ID must be unique
- Color mutation must contain letters only
- Hatch year must be between 1900 and 2026
- Required ComboBox fields must be selected

### Random Data Generation

The system can generate 10,000 random bird records and display them in the data table.

A progress bar is used to visually show the generation process.

### Bird Inventory Table

All birds are displayed in a DataGridView table.

The table presents the bird data in a clean inventory-style view.

### Sorting

The system includes two sorting implementations:

- Bubble Sort
- QuickSort

The main report uses QuickSort to sort birds by hatch year in descending order.

### Inventory Report

The system generates a report that includes:

- Total number of birds
- Average bird age
- Number of birds available for sale
- QuickSort execution time

### Bird Details

Users can double-click a bird in the table to view detailed information about that bird.

## Testing

The project includes a separate MSTest project for testing core logic.

Tested areas include:

- Sorting functionality
- Average age calculation
- Counting birds available for sale
- Bird availability update logic

## Project Structure

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

## Core Classes

### Bird

Represents a bird in the aviary system.

Main properties:

- RingId
- Type
- ColorMutation
- HatchYear
- Status
- AvailableForSale

### Form1

The main Windows Forms interface.

Responsible for:

- User interaction
- Input validation
- Displaying bird data
- Updating the inventory table
- Generating reports
- Styling the UI

### IHealthService

Defines a health-check service interface.

### HealthService

Implements bird health-check logic used to update sale availability.

## Screenshots

Add screenshots of the system here.

Example:

![Main Screen](screenshots/main-screen.png)

## How to Run

1. Clone the repository:

git clone https://github.com/yahav11/BirdAviaryManagement.git

2. Open the solution in Visual Studio.

3. Build the solution.

4. Run the WinForms project.

## How to Run Tests

1. Open the solution in Visual Studio.
2. Open Test Explorer.
3. Run all tests.

## Notes

This project was created as an academic Windows Forms project.  
The main focus is on implementing basic data management, validation, sorting algorithms, reporting logic, and unit testing.

## Author

Developed by Yahav Gueta & Tehila Atedgi
