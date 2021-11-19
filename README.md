# Board Game Picker

ASP.NET Core MVC application created as my project for the Code Louisville .NET course. Consists of a database of board games, and the ability to pick a game at random based on the number of players and how much time you have. You can also filter the entire game list based on the same criteria.

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

### Code Louisville Project Requirements

#### Basic Requirements
- [x] Project is uploaded to your GitHub repository and shows at minimum 5 separate commits
- [x] Project includes a README file
- [x] You must create at least one class, then create at least one object of that class and populate it with data, and use or display the data in your application
- [x] Create and call at least 3 functions or methods, at least one of which must return a value that is used in your application
- [x] Choose at least 3 items on the Features List below and implement them in your project

#### Feature List
- [ ] Make at least one unit test
- [x] Create an additional class which inherits one or more properties from its parent
- [x] Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program
- [ ] Implement a log that records errors, invalid inputs, or other important events and writes them to a text file
- [x] Read data from an external file, such as text, JSON, CSV, etc and use that data in your application
- [ ] Implement a regular expression (regex) to ensure a field either a phone number or an email address is always stored and displayed in the same format
- [ ] Connect to an external/3rd party API and read data into your app
- [x] Use a LINQ query to retrieve information from a data structure (such as a list or array) or file
- [ ] Create 3 or more unit tests for your application
- [ ] Build a conversion tool that converts user input to another type and displays it (ex: converts cups to grams)
- [ ] Calculate and display data based on an external factor (ex: get the current date, and display how many days remaining until some event)
- [ ] Analyze text and display information about it (ex: how many words in a paragraph)
- [x] Visualize data in a graph, chart, or other visual representation of data
