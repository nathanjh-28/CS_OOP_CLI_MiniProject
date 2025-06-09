///////////////////////////////////////////////////////////////////////////////
/// Filename: Project.cs
/// Author: Nathan Harris
/// Date: 2025-06-09
/// Description:  This class keeps track of a project and it's list of tasks
///////////////////////////////////////////////////////////////////////////////

namespace Projects;

public class Project
{
    private int Project_Start_Number = 42; // starting number for project IDs

    ///////////////////////////////////////////////////////////////////////////
    //      attributes
    ///////////////////////////////////////////////////////////////////////////
    public string ClientName { get; }
    public int NumShootDays { get; set; }
    public string ProjectNumber { get; }
    private List<Task> _allTasks = new List<Task>(); // List of Tasks

    public Task? NextUnfinishedTask
    {
        get
        {
            foreach (var task in _allTasks)
            {
                if (!task.isComplete)
                {
                    return task;
                }
            }
            return null;
        }
    }

    ///////////////////////////////////////////////////////////////////////////
    //      constructor
    ///////////////////////////////////////////////////////////////////////////
    public Project(string clientName, int shootDays)
    {
        this.ClientName = clientName;
        this.NumShootDays = shootDays;
        this.ProjectNumber = Project_Start_Number.ToString();
        Project_Start_Number++;
    }

    ///////////////////////////////////////////////////////////////////////////
    //      methods
    ///////////////////////////////////////////////////////////////////////////

    // push a new task on to the task list
    public void AddTask(string task_name, int difficulty)
    {
        // input validation here

        Task newTask = new Task(task_name, difficulty);
        _allTasks.Add(newTask);
    }

    // Mark the next task as complete
    public Task? CompleteTask()
    {
        // for now mark the next unfinished task as complete
        if (this.NextUnfinishedTask != null)
        {
            Task CompleteTask = this.NextUnfinishedTask;
            CompleteTask.isComplete = true;
            return CompleteTask;
        }
        else
        {
            return null;
        }

    }

    // Print all tasks for this project
    public string GetTaskList()
    {
        var taskList = new System.Text.StringBuilder();

        taskList.AppendLine("Task Name\t\t\tDifficulty\t\t\tCompleted");
        foreach (var task in _allTasks)
        {
            string tempComplete = "NOT Complete";
            if (task.isComplete)
            {
                tempComplete = "DONE!";
            }
            taskList.AppendLine($"{task.Taskname}\t\t\t{task.Difficulty}\t\t\t{tempComplete}");
        }
        return taskList.ToString();
    }

    // virtual method to be overwritten by derived classes
    public virtual void PrepForShoot() { }

}

