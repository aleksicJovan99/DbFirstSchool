using DbFirstSchool.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DbFirstSchool.Controllers;

[ApiController]
[Route("/api/class")]
public class ClassController : ControllerBase
{
    private IGenericRepository _repository;

    public ClassController(IGenericRepository repository)
    {
        _repository = repository;
    }

   [HttpGet]
    public IActionResult GetAllClasses()
    {
        return Ok(_repository.GetAll<Class>());
    }

    [HttpPost]
    public IActionResult InsertClass(Class className)
    {
        _repository.Insert(className);
        _repository.Save();
        return Ok();
    }
}