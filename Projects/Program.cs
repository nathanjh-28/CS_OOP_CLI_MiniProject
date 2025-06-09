///////////////////////////////////////////////////////////////////////////////
/// Filename: Program.cs
/// Author: Nathan Harris
/// Date: 2025-06-09
/// Description: This file runs the app and a series of demo commands
/// Usage: use dotnet run to run the demo
///////////////////////////////////////////////////////////////////////////////


using Projects;

Console.WriteLine("");
Console.WriteLine("Hello and welcome to the Projects CLI App.");
Console.WriteLine("");

var my_proj = new Project("Steve the Client", 2);
Console.WriteLine("Adding tasks: sign agreement, scout location, approve short list");
my_proj.AddTask("sign agreement", 1);
my_proj.AddTask("scout location", 2);
my_proj.AddTask("Approve shot list", 3);
Console.WriteLine($"next task: {my_proj.NextUnfinishedTask?.Taskname}");
Console.WriteLine("***completing task***");
my_proj.CompleteTask();
Console.WriteLine($"next task: {my_proj.NextUnfinishedTask?.Taskname}");
Console.WriteLine("");
Console.WriteLine("Task List:");
Console.WriteLine(my_proj.GetTaskList());

Console.WriteLine("Demo of Projects CLI App complete!");

