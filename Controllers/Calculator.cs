using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers;
[ApiController]
[Route("[controller]")]
public class Calculator : ControllerBase
{
    [HttpGet("Add")]
    public ActionResult<decimal> Add(decimal x, decimal y)
    {
        var result = x + y;
        return result;
    }
    [HttpGet("Subtract")]
    public ActionResult<decimal> Subtract(decimal x, decimal y)
    {
       var result = x - y;
        return result;
    }
    [HttpGet("Multiply")]
    public ActionResult<decimal> Multiply(decimal x, decimal y)
    {
        var result = x + y;
        return result;
    }
    [HttpGet("Divide")]
    public ActionResult<decimal> Divide(decimal x, decimal y)
    {
        if(y==0)
        {
            return BadRequest("Unable to process division by zero");
        }
        var result = x / y;
        return result;
    }
    [HttpGet("Modulo")]
    public ActionResult<decimal> Modulo(decimal x, decimal y)
    {
        if(y==0)
        {
            return BadRequest("Unable to process modulo operation");
        }
        var result = x % y;
        return result;
    }
}