# Board Game Picker

ASP.NET Core MVC application created as my project for the Code Louisville .NET course. Consists of a database of board games, and the ability to pick a game at random based on the number of players and how much time you have.

### Running the Application

#### Visual Studio

1. Open the **BoardGamePicker** solution in Visual Studio
2. From the Package Manager Console, run **Update-Database**
3. Click on the **BoardGamePicker** project in the Solution Explorer
4. Start the application from **Debug > Start Without Debugging**, or press **Ctrl+F5**

#### .NET CLI

1. Navigate to the project directory
2. From the Command Line, run **dotnet ef database update**
3. Run **dotnet run** to start the application
4. Navigate to **https://localhost:5001**
