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
}

