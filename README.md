# ContactManagementSys

# Setup
- Uses Sql Server Express LocalDB (If using Visual Studio install it under Individual Components in the Visual Studio installer or install separately using [this link](https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-2016-express-localdb?view=sql-server-2017).
- Apply database migrations to create the db.  From a command line within the *Data.Access* project folder use the dotnet CLI to run : <code>Data.Access>**dotnet ef database update**</code>

# Visual Studio
Simply open the solution file <code>ContactManagementSystem.sln</code> and build/run.

# Visual Studio Code
Open the <code>src</code> folder and <code>F5</code> to build/run.
