# Bank Account Form

A simple Windows Forms application for managing bank accounts, built with C# and .NET 8.0.

## Overview

This desktop application provides a basic interface for creating and managing bank accounts. Users can create new accounts with owner names and view account details in a data grid.

## Features

- **Create Account**: Add new bank accounts with owner names
- **Account Display**: View all accounts in a structured data grid
- **Unique Account Numbers**: Each account gets a unique GUID-based account number
- **Balance Tracking**: Track account balances (starts at $0.00)

### Planned Features
The UI includes buttons for additional functionality that can be implemented:
- **Deposit**: Add money to accounts
- **Withdraw**: Remove money from accounts

## Technical Details

### Requirements
- Windows operating system
- .NET 8.0 Runtime
- Visual Studio 2017 or later (for development)

### Project Structure
```
BankAccountForm/
├── BankAccountForm.sln          # Visual Studio solution file
├── BankAccountForm/
│   ├── BankAccountForm.csproj   # Project configuration
│   ├── Program.cs               # Application entry point
│   ├── Form1.cs                 # Main form logic
│   ├── Form1.Designer.cs        # Form UI design
│   ├── Form1.resx              # Form resources
│   └── bankAccount.cs           # BankAccount class definition
├── .gitignore                   # Git ignore rules
└── .gitattributes              # Git attributes
