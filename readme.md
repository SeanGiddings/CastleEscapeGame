![.NET Core](https://github.com/am1983/TestConsoleApp/workflows/.NET%20Core/badge.svg)

This is just a test project so I can play around with .NET Core solutions, code organization, and GitHub actions.

Nothing to see here. Please move along and have a great day!

# Work in Progress

This documentation is a work-in-progress. The end goals are to help new C# developers:

* Create a .NET Core solution.
* Create at least 2 .NET Core projects and add them to the solution.
* Initialize a Git repo and get that on GitHub.
* Add a GitHub Actions workflow that will build their .NET Core solution on each commit/PR and run any unit tests that have been created.
* Add a status badge to their documentation so that anyone viewing or evaluating their work will be certain that the code will build on their computer.

If you would like to help, please feel free to fork this repository and submit a PR with your proposed changes. If you are unable to submit a PR, please submit an issue and I will take a look at it.

# Creating a Solution File

A solution file contains all of the code that supports your application. This will often include the application itself ("TestConsoleApp") as well as unit tests ("TestConsoleApp.Tests") as well as other projects that are a part of your application. 

* Create a folder where ALL of your code will live. Ideally, it will be named for your project. (ex: "TestConsoleApp")
* Change in to that directory: `cd TestConsoleApp`
* Use the dotnet core CLI to create a solution file: `dotnet new sln`
  * This will create a file with the .sln extension (ex: "TestConsoleApp.sln")

* Alternative: You can make all three of the above steps happen at once with the following command: `dotnet new sln -n TestConsoleApp -o TestConsoleApp`. This will create a new dotnet solution file with the name "TestConsoleApp" and will place it in a new folder also called "TestConsoleApp".

# Creating New Projects

Your solution file will contain the project(s) that make up your application. A solution file will allow you to manage multiple related projects as a single unit. As an added bonus, it will make the code easier to open in Visual Studio. For the sake of this demo, I am adding two projects - one for the console application and the other for unit testing.

* From inside of the solution directory (or workspace folder, whatever you want to call that) create a new console application project:
  `dotnet new console -n TestConsoleApp -o TestConsoleApp.`
  * -n tells dotnet to call the project "TestConsoleApp".
  * -o tells dotnet to put that project in a folder called "TestConsoleApp".
* Add your new console application project to the solution: `dotnet sln add .\TestConsoleApp\TestConsoleApp.csproj` (tab completion will help here).
* Add your test project: `dotnet new xunit -n TestConsoleApp.Tests -o TestConsoleApp.Tests`
  * -n tells dotnet to call the project "TestConsoleApp.Tests".
  * -o tells dotnet to put that project in a folder called "TestConsoleApp.Tests".
* Add the test project to the solution: `dotnet sln add .\TestConsoleApp.Tests\TestConsoleApp.Tests.csproj`

# Getting Ready for GitHub

* Add an empty file to the solution directory called ".gitignore". 
* Consider copying and pasting the contents of this file to your new .gitignore file: https://github.com/dotnet/core/blob/master/.gitignore . This will tell Git to ignore changes to files that match the patterns in the .gitignore file.
* Initialize a new git repository in your solution directory: `git init`
* Get ready to save the work you have done by staging it for source control: `git add .`
* Commit the changes you have made so far: `git commit -m 'Initial commit'`
* Add a remote repository so you can push your code to GitHub: (ex: `git remote add origin https://github.com/am1983/TestConsoleApp.git`)
* Push the changes to GitHub: `git push -u origin master`
  * You only have to use `git push -u ...` once. This just tells git that you want to push changes upstream to the remote called origin from the branch called master. Once you have done this, you can just type `git push` to push future changesets to GitHub.

# Setting up .NET Core Build Actions in GitHub

* Go to your repository in GitHub (ex: https://github.com/am1983/TestConsoleApp)
* Click on "Actions"
* GitHub will detect what kind of code you have in the repository and should suggest a .NET Core workflow.
* Add this workflow to your project.
  * There will be an option on the right hand side of the screen when you select the .NET Core workflow to commit the changes. Definitely do this. 
* Back in Visual Studio Code (or your terminal) type `git pull`. This will pull the changes that should have been committed to master when you added the .NET Core workflow.
* Go back to GitHub and look for your new workflow under Actions. When you click on the .NET Core workflow, you will see an option to create a status badge on the right hand side. Click that button and then the button labelled "Copy status badge Markdown". This will copy some Markdown to your clipboard.
* Create a new file in your solution directory called "readme.md".
* Add the code you copied from GitHub in to this new file.
* Save your changes and then commit them:
  * In terminal, type: `git add .` to add the changes to your next commit.
  * Type: `git commit -m 'Adding status badge'`
  * Type: `git push`
* Go back to your repository in GitHub: (ex: https://github.com/am1983/TestConsoleApp)
* Scroll down and you will see a status badge in the documentation below the files listed in your repository.

# Developer Workflow

This is the workflow I follow when working on small projects. I'm intentionally omitting the discussion of branching from master, making changes, and then submitting a pull request. For the purposes of this documentation, that discussion can wait until later.

1) `git pull`: To get the latest updates to the code base.
2) Make a small but complete set of changes.
3) Add unit tests (as needed).
4) `dotnet build`: Let's make sure the code builds. Do NOT commit broken code. If it won't build, consider using "stash" instead.
5) `dotnet test`: Assuming your project builds and you have written unit tests, now is a great time to run those tests. Do NOT commit code if the tests are broken.
6) `git add .`: Stage the changes I have made. Let's get them ready to go.
7) `git commit -m '{{message}}'`: Commit the changes locally. This defines the set of changes we are going to save.
8) `git push`: Push the changeset (commit) to GitHub (or whatever Git hosting service you are using).
9) Walk away. Take a short break away from the monitor. 

**Rinse and repeat**
