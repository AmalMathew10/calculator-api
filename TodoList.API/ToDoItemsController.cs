[ApiController]
[Route("api/[controller]")]
public class ToDoItemsController : ControllerBase
{
    private readonly DatabaseContext _context;

    public ToDoItemsController(DatabaseContext context)
    {
        _context = context;
    }

    
    [HttpGet("{id}")]
    public ActionResult<ToDoItem> GetToDoItem(int id)
    {
        var toDoItem = _context.ToDoItems.Find(id);

        if (toDoItem == null)
        {
            return NotFound();
        }

        return Ok(toDoItem);
    }

    [HttpPost]
    public ActionResult<ToDoItem> PostToDoItem(ToDoItem toDoItem)
    {
        _context.ToDoItems.Add(toDoItem);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetToDoItem), new { id = toDoItem.Id }, toDoItem);
    }

    [HttpPost("{id}")]
    public ActionResult<ToDoItem> CompleteToDoItem(int id)
    {
        var toDoItem = _context.ToDoItems.Find(id);

        if (toDoItem == null)
        {
            return NotFound();
        }

        toDoItem.CompletedDate = DateTime.Now;
        _context.SaveChanges();

        return Ok(toDoItem);
    }
}
