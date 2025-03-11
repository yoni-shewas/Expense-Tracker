# 🏧 Expense Tracker

A Windows Forms application built with C# that helps users track their expenses efficiently. This application integrates a local Microsoft SQL Server database for data storage and features three main tabs: Home, Profile, and Expenses.

## 📌 Features

- **User Authentication**: Login/logout functionality.
- **Dashboard Overview**: Displays total income, total expenses, remaining budget, and a visual expense summary (pie chart).
- **Recent Transactions**: Shows a detailed list of expenses categorized by user, category, amount, and date.
- **Expense Management**: Users can add, edit, and delete expenses.
- **Category Management**: Allows users to manage spending categories.
- **Budgeting Feature**: Users can set a budget to monitor expenses effectively.

## 🖥️ UI Overview

- **Home Tab**: Displays an overview of expenses, a summary chart, and recent transactions.
- **Profile Tab**: Allows users to manage personal information.
- **Expenses Tab**: Provides an interface for adding, editing, and tracking expenses.

## 🛠️ Tech Stack

- **C# with Windows Forms (WinForms)**
- **Microsoft SQL Server (Local Database)**
- **.NET Framework**

## 👤 Project Structure

```
/ExpenseTracker
│── App.config
│── Program.cs
│── DBConnection.cs
│── ExpenseDB.mdf  # Local database
│── ExpenseDBDataSet.xsd  # Database schema
│── LoginForm.cs
│── Dashboard.cs
│── Budget.cs
│── Category.cs
│── Expense.cs
│── User.cs
│── Forms/
│   ├── LoginForm.cs
│   ├── Dashboard.cs
│   ├── ExpenseForm.cs
│── Resources/
│   ├── Icons
│   ├── Styles
```

## 🔧 Setup & Installation

1. **Clone the repository:**

   ```sh
   git clone https://github.com/your-username/expense-tracker.git
   cd expense-tracker
   ```

2. **Open the project in Visual Studio.**
3. **Restore NuGet packages if needed.**
4. **Configure the database connection in `DBConnection.cs`:**

   ```csharp
   string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ExpenseDB;Integrated Security=True;";
   ```

5. **Run the project in Visual Studio.**

- Using **.sln** file in the project
