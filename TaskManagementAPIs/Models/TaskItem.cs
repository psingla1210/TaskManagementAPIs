﻿namespace TaskManagementAPIs.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        public required string Title { get; set; }

        public required string Description { get; set; }

        public required string Status { get; set; }

        public required string Priority { get; set; }

        public required DateTime DueDate { get; set; }

        public required string AssignedUser { get; set; }
    }
}
