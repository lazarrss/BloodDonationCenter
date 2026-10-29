# Blood Donation Center

A **C# Windows Forms** desktop application for a blood donation center, connected to a **SQL Server** database.

The app supports three user roles:

- **Donor**: registers, views donation history and statistics (blood donated, lives saved), and sees urgent blood requests.
- **Doctor**: adds patients, searches for available blood by blood group, and reviews donors.
- **Acceptor**: manages their account and reviews donors.

**Tech stack:** C# · .NET Framework · Windows Forms · SQL Server (ADO.NET)

## Running

Open `WindowsFormsApp1.csproj` in Visual Studio, set the `conString` connection string in `Form1.cs` to your SQL Server instance (database `DonacijaKrvi`), and run the project.
