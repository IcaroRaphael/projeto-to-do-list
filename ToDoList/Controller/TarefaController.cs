using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ToDoList.Context;

namespace ToDoList.Controller;

[Route("[controller]")]
[ApiController]
public class TarefaController
{
    private readonly AppDbContext _context;

    public TarefaController(AppDbContext context)
    {
        _context = context;
    }
}
