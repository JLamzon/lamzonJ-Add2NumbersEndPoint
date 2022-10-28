//Jessie Lamzon
//10-25-22
//Add 2 Numbers - Endpoint
//endpoints configured to complete Mini Challenge # 2 
//from the Coding Combine.
//peer review: jasmine leek: Code works! and does what challenge requires!


using Microsoft.AspNetCore.Mvc;

namespace lamzonJ_Add2NumbersEndPoint.Controllers;

[ApiController]
[Route("[controller]")]
public class Adding2NumbersController : ControllerBase
{
    [HttpGet]
    //......add args into route for input
    [Route("Adding/{number1}/{number2}")]

    public int Adding(string number1, string number2)
    {
        //Converting string to integer for calculation
        int numOne = Convert.ToInt32(number1);
        int numTwo = Convert.ToInt32(number2);

        return numOne + numTwo;
    }
}
