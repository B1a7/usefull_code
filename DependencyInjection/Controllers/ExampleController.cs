using Dependencyinjection.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dependencyinjection.Controllers;
public class ExampleController : Controllerbase
{
    private readonly IService _service;

    public ExampleController(IService service)
    {
        _ service = service;
    }


    [HttpGet("id")]
    public IActionResult Example()
    {
        return Ok(_service.GetType().Name);
    }

}