using Microsoft.EntityFrameworkCore;
using TodoList.Models;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
    }

    public DbSet<ToDoItem> ToDoItems { get; set; }
}
