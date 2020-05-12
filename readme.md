![.NET Core](https://github.com/am1983/TestConsoleApp/workflows/.NET%20Core/badge.svg)

This is just a test project so I can play around with .NET Core solutions, code organization, and GitHub actions.

Nothing to see here. Please move along and have a great day!

# Creating a Solution File

A solution file contains all of the code that supports your application. This will often include the application itself ("TestConsoleApp") as well as unit tests ("TestConsoleApp.Tests") as well as other projects that are a part of your application. 

* Create a folder where ALL of your code will live. Ideally, it will be named for your project. (ex: "TestConsoleApp")
* Change in to that directory. ("cd TestConsoleApp")
* Use the dotnet core CLI to create a solution file: "dotnet new sln"
  * This will create a file with the .sln extension (ex: "TestConsoleApp.sln")

# Creating New Projects

Your solution file will contain the project(s) that make up your application. For the sake of this demo, I am adding two projects - one for the console application and the other for unit testing.

* From inside of the solution directory (or workspace folder, whatever you want to call that) create a new console application project:
  "dotnet new console -n TestConsoleApp -o TestConsoleApp."
  * -n tells dotnet to call the project "TestConsoleApp".
  * -o tells dotnet to put that project in a folder called "TestConsoleApp".
* Add your new console application project to the solution: "dotnet sln add .\TestConsoleApp\TestConsoleApp.csproj" (tab completion will help here).
* Add your test project: dotnet new xunit -n TestConsoleApp.Tests -o TestConsoleApp.Tests
  * -n tells dotnet to call the project "TestConsoleApp.Tests".
  * -o tells dotnet to put that project in a folder called "TestConsoleApp.Tests".
* Add the test project to the solution: "dotnet sln add .\TestConsoleApp.Tests\TestConsoleApp.Tests.csproj"

# Getting Ready for Git

* Add an empty file to the solution directory called ".gitignore". 
* Consider copying and pasting the contents of this file to your new .gitignore file: https://github.com/dotnet/core/blob/master/.gitignore . This will tell Git to ignore changes to files that match the patterns in the .gitignore file.
* Initialize a new git repository in your solution directory: "git init"
* Get ready to save the work you have done by staging it for source control: "git add ."
* Commit the changes you have made so far: "git commit -m 'Initial commit'"
* Add a remote repository so you can push your code to GitHub: (ex: "git remote add origin https://github.com/am1983/TestConsoleApp.git")
* Push the changes to GitHub: "git push -u origin master"
  * You only have to use "git push -u ..." once. This just tells git that you want to push changes upstream to the remote called origin from the branch called master. Once you have done this, you can just type "git push" to push future changesets to GitHub.