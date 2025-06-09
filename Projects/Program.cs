///////////////////////////////////////////////////////////////////////////////
/// Filename: Program.cs
/// Author: Nathan Harris
/// Date: 2025-06-09
/// Description: This file runs the app and a series of demo commands
/// Usage: use dotnet run to run the demo
///////////////////////////////////////////////////////////////////////////////


using Projects;

Console.WriteLine("Hello and welcome to the Projects CLI App.");

var my_proj = new Project("Steve the Client", 2);
my_proj.AddTask("sign agreement", 1);
my_proj.AddTask("scout location", 2);
my_proj.AddTask("Approve shot list", 3);
Console.WriteLine($"next task: {my_proj.NextUnfinishedTask.Taskname}");
Console.WriteLine("completing first task");
my_proj.CompleteTask();
Console.WriteLine($"next task: {my_proj.NextUnfinishedTask.Taskname}");
Console.WriteLine(my_proj.GetTaskList());

Console.WriteLine("Demo complete!");

// demonstrate app