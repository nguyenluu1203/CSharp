using System;

namespace CShar.Lab3
{
    public delegate void TaskStatusChangedEventHandler(object sender, TaskStatusChangedEventArgs e);

    public class Task
    {
        public string Name { get; set; }
        private bool isCompleted;

        public event TaskStatusChangedEventHandler TaskStatusChanged;

        public bool IsCompleted
        {
            get { return isCompleted; }
            set
            {
                if (value != isCompleted)
                {
                    isCompleted = value;
                    OnTaskStatusChanged(new TaskStatusChangedEventArgs(this));
                }
            }
        }

        protected virtual void OnTaskStatusChanged(TaskStatusChangedEventArgs e)
        {
            TaskStatusChanged?.Invoke(this, e);
        }
    }
}