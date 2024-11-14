using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using TaskManagementAPIs.Models;

namespace TaskManagementAPIs.Data
{
    public class TaskDBContext : DbContext
    {
        public DbSet<TaskItem> Tasks { get; set; }

        public TaskDBContext(DbContextOptions<TaskDBContext> options) : base(options) { }
    }
}
