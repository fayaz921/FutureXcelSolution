FutureXcel — Week 1 Setup
Overview

• This is the Week 1 setup for the FutureXcel Full-Stack project
• ASP.NET Core Web API with a working /api/health route
• Frontend index.html served from the wwwroot folder
• SQL Server database connection with a test table Testitems
• Branding: Built by Muhammad Fayaz

How to Run

• Clone the repository and open the solution in Visual Studio
• Ensure SQL Server is running
• Update the connection string in appsettings.json if needed:

"ConnectionStrings": {
  "Myconn": "Server=M-FAYAZ;Database=FutureXcelDb;TrustServerCertificate=True;Trusted_Connection=True;"
}


• Apply migrations:

dotnet ef database update


• Press Start in Visual Studio
• The browser will open automatically and load the frontend
• The /api/health route should display the health check status

Author

• Built by Muhammad Fayaz