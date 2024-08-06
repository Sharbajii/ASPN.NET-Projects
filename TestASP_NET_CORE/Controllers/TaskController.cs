using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TestASP_NET_CORE.Data;
using TestASP_NET_CORE.Helper;
using Task = TestASP_NET_CORE.Data.Task;

[ApiController]
[Route("api/[controller]")]
public class TasksController : ControllerBase
{
    private readonly TodoContext _context;
    private readonly UserManager<IdentityUser> _userManager;
    private readonly string _connectionString;

    public TasksController(TodoContext context, UserManager<IdentityUser> userManager, IConfiguration configuration)
    {
        _context = context;
        _userManager = userManager;
        _connectionString = configuration.GetConnectionString("DefaultConnection")!;
    }
    /*
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Task>>> GetTasks()
    {
        var userId = Guid.Parse(_userManager.GetUserId(User));
        var minDate = DateTime.Today.AddDays(-30);

       
        var tasks = dbElementsManipulation.GetTasks()
                                           .Where(t => t._userId == userId && t._date >= minDate)
                                           .ToList();

        return tasks.OrderByDescending(t => t._date).ToList();
    }*/
    /*
    [HttpPost]
    public async Task<ActionResult<Task>> PostTask(Task task)
    {
        task._userId = Guid.Parse(_userManager.GetUserId(User));
        _context.Tasks.Add(task);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetTasks), new { id = task._taskId }, task);
    }
    */
    [HttpPut("{id}")]
    public async Task<IActionResult> PutTask(int id, Task task)
    {
        if (id != task._taskId)
        {
            return BadRequest();
        }

        var userId = Guid.Parse(_userManager.GetUserId(User)!);
        if (task._userId != userId)
        {
            return Unauthorized();
        }

        _context.Entry(task).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!_context.Tasks.Any(e => e._taskId == id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTask(int id)
    {
        var userId = Guid.Parse(_userManager.GetUserId(User)!);
        var task = await _context.Tasks.FindAsync(id);
        if (task == null || task._userId != userId)
        {
            return NotFound();
        }

        _context.Tasks.Remove(task);
        await _context.SaveChangesAsync();

        return NoContent();
    }
}