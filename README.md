# Recipe_App

A small C# console application that demonstrates a simple recipe book. 
The app lets the user browse a list of recipes and view details such as ingredients, instructions, estimated time and servings.

Features
- Browse all recipes
- View recipe details (type, time, servings, description, ingredients, instructions)

Prerequisites
- .NET 10 SDK (the project targets .NET 10)

Build and run
- Using the .NET CLI:
  - dotnet build
  - dotnet run --project Recipe_App.csproj
- Using Visual Studio: open the solution or project and run the project (F5 or Ctrl+F5).

Usage
- On start the app shows a menu with options:
  1 - See all recipes
  0 - Exit
- Press the number key for the desired option and follow on-screen prompts. When viewing the recipe list, enter the recipe index number to show the full recipe details, or press ENTER to go back.

Project structure
- Program.cs - application entry point
- App.cs - main loop and menu handling
- Menu.cs - console UI helper methods
- Recipe.cs - recipe model and display logic
- RecipeBook.cs - in-memory collection of sample recipes

