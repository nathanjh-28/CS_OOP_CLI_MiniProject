///////////////////////////////////////////////////////////////////////////////
/// Filename: Task.cs
/// Author: Nathan Harris
/// Date: 2025-06-09
/// Description: This class defines the task unit stored in a Project instance
///////////////////////////////////////////////////////////////////////////////

namespace Projects;

public class Task
{
    // attributes
    public string Taskname { get; }
    public int Difficulty { get; }
    public bool isComplete { get; set; }

    // constructor
    public Task(string task_name, int difficulty)
    {
        Taskname = task_name;
        Difficulty = difficulty;
        isComplete = false;
    }


}