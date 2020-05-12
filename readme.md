![.NET Core](https://github.com/am1983/TestConsoleApp/workflows/.NET%20Core/badge.svg)

This is just a test project so I can play around with .NET Core solutions, code organization, and GitHub actions.

Nothing to see here. Please move along and have a great day!

# Creating a Solution File

A solution file contains all of the code that supports your application. This will often include the application itself ("TestConsoleApp") as well as unit tests ("TestConsoleApp.Tests") as well as other projects that are a part of your application. 

* Create a folder where ALL of your code will live. Ideally, it will be named for your project. (ex: "TestConsoleApp")
* Change in to that directory. ("cd TestConsoleApp")
* Use the dotnet core CLI to create a solution file: "dotnet new sln"
  * This will create a file with the .sln extension (ex: "TestConsoleApp.sln")