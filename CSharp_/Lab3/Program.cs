using System;

namespace CShar.Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskList taskList = new TaskList();

            Task task1 = new Task { Name = "Task 1", IsCompleted = false };
            Task task2 = new Task { Name = "Task 2", IsCompleted = true };
            Task task3 = new Task { Name = "Task 3", IsCompleted = false };

            taskList.AddTask(task1);
            taskList.AddTask(task2);
            taskList.AddTask(task3);

            Console.WriteLine("Tasks not completed:");
            taskList.DisplayTasks(false);

            task1.IsCompleted = true;

            Console.WriteLine("\nTasks completed:");
            taskList.DisplayTasks(true);
        }
    }
}