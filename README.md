# ND_Housing_TEST_Project_CAMDen coded in C#
# CSV Cell Viewer – Windows Forms Application

This is a simple Windows Forms application built in C# using .NET. It loads a CSV file and displays the data in a table (DataGridView). Double-clicking any cell opens a popup window showing the value of that cell, along with its row and column number.

---

## Features

- Automatically loads data from a `.csv` file when the application starts
- Displays the contents in a user-friendly table view
- Double-click any cell to:
  - Open a new window with the cell's value
  - See its row/column location (e.g., `Cell (2,3)`)
  - Show a message if the cell is empty
- Includes basic error logging to a text file (`app_error_log.txt`) on the Desktop

---

## Project Structure

- `Form1.cs` – Main form that loads the CSV and handles UI logic
- `ValueDisplayFormWhenDoubleClicked.cs` – Popup form that shows cell value on double-click
- `data.csv` – Example data file (can be replaced or edited)

---

## How to Run

1. Clone or download the project from GitHub
2. Open the solution (`.sln`) in Visual Studio
3. Make sure `data.csv` is placed in the specified folder (or update the file path in `Form1.cs`)
4. Press `Start` (or F5) to run the application

---

## CSV Format Example
```csv
1,2,3
4,5,6
7,8,9
10,11,12
13,14,15
```

## Requirements

- Visual Studio 2022 or later
- .NET Framework (or .NET 6/7, depending on your setup)
 **.NET Desktop Development** workload installed in Visual Studio
> To install this workload:  
> Open Visual Studio Installer → Modify → Check ".NET Desktop Development" → Click Modify.

## Error Logging
If any errors occur (e.g., file not found, missing values, or format issues), they will be automatically logged to a file located on your desktop:
