using Microsoft.AspNetCore.Mvc;
using unittest;

[Route("api/[controller]")]
[ApiController]
public class unittest : ControllerBase
{
    private readonly Calculator _calculator;

    public unittest(Calculator calculator)
    {
        _calculator = calculator;
    }

    [HttpGet("add/{a}/{b}")]
    public ActionResult<int> Add(int a, int b)
    {
        return Ok(_calculator.Add(a, b));
    }

    
}
