using Microsoft.EntityFrameworkCore;
using ToDoList.Model;

namespace ToDoList.Context;

public class AppDbContext : DbContext
{
    protected AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
    
    public DbSet<Tarefa>? Tarefas { get; set; }
}
