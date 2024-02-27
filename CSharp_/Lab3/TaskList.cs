using System;
using System.Collections.Generic;

namespace CShar.Lab3
{
    public class TaskList
    {
        private List<Task> tasks;

        public TaskList()
        {
            tasks = new List<Task>();
        }

        public void AddTask(Task task)
        {
            tasks.Add(task);
            task.TaskStatusChanged += OnTaskStatusChanged;
        }

        public void DisplayTasks(bool completed)
        {
            Console.WriteLine($"{"Name",-20}{"Status",-15}");
            foreach (var task in tasks)
            {
                if (task.IsCompleted == completed)
                {
                    Console.WriteLine($"{task.Name,-20}{(task.IsCompleted ? "Completed" : "Not Completed"),-15}");
                }
            }
        }

        private void OnTaskStatusChanged(object sender, TaskStatusChangedEventArgs e)
        {
            Task task = e.Task;
            Console.WriteLine(
                $"Task \"{task.Name}\" has been {(task.IsCompleted ? "completed" : "marked as not completed")}");
        }

    }
}