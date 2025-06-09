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
Console.WriteLine($"Created new Project with client name: {my_proj.ClientName}");
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


Console.WriteLine("Creating new PromoVideo Project");

var my_promo_vid = new PromoVideo("Frank the video Client", 2, 10);
Console.WriteLine($"Created new Promo Video Project with client name: {my_promo_vid.ClientName}");
Console.WriteLine($"Video length needed in minutes: {my_promo_vid.VideoLength}");
Console.WriteLine("Calling prep for shoot which adds template tasks for promo video shoots");
my_promo_vid.PrepForShoot();
Console.WriteLine($"next task: {my_promo_vid.NextUnfinishedTask?.Taskname}");
Console.WriteLine("***completing task***");
my_promo_vid.CompleteTask();
Console.WriteLine($"next task: {my_promo_vid.NextUnfinishedTask?.Taskname}");
Console.WriteLine("");
Console.WriteLine("Task List:");
Console.WriteLine(my_promo_vid.GetTaskList());


Console.WriteLine("Creating new Photo Shoot Project");
var my_photoshoot = new PhotoShoot("Mike the photo Client", 2, 25);
Console.WriteLine($"Created new Photo Project with client name: {my_photoshoot.ClientName}");
Console.WriteLine($"Number of images needed: {my_photoshoot.NumImages}");
Console.WriteLine("Calling prep for shoot which adds template tasks for promo video shoots");
my_photoshoot.PrepForShoot();
Console.WriteLine($"next task: {my_photoshoot.NextUnfinishedTask?.Taskname}");
Console.WriteLine("***completing task***");
my_photoshoot.CompleteTask();
Console.WriteLine($"next task: {my_photoshoot.NextUnfinishedTask?.Taskname}");
Console.WriteLine("");
Console.WriteLine("Task List:");
Console.WriteLine(my_photoshoot.GetTaskList());

Console.WriteLine("");
Console.WriteLine("Demo of Projects CLI App complete!");

