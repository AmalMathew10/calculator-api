using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyProject.Controllers;
[ApiController]
[Route("[controller]")]
public class Calculator : ControllerBase
{
    [HttpGet("Add")]
    public ActionResult<decimal> Add(decimal number1, decimal number2)
    {
        return number1 + number2;
    }
    [HttpGet("Subtract")]
    public ActionResult<decimal> Subtract(decimal number1, decimal number2)
    {
        return number1 - number2;
    }
    [HttpGet("Multiply")]
    public ActionResult<decimal> Multiply(decimal number1, decimal number2)
    {
        return number1 * number2;
    }
    [HttpGet("Divide")]
    public ActionResult<decimal> Divide(decimal number1, decimal number2)
    {
        if(number2==0)
        {
            return BadRequest("Can't divided by zero");
        }
        return number1 / number2;
    }
    [HttpGet("Modulo")]
    public ActionResult<decimal> Modulo(decimal number1, decimal number2)
    {
        if(number2==0)
        {
            return BadRequest("Can't find out modulo");
        }
        return number1 % number2;
    }
}