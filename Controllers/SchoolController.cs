using DbFirstSchool.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DbFirstSchool.Controllers;

[ApiController]
[Route("api/school")]
public class SchoolController : ControllerBase
{
    private readonly IGenericRepository _repository;

    public SchoolController(IGenericRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public IActionResult GetAllSchool()
    {
        return Ok(_repository.GetAll<School>());
    }

    [HttpPost]
    public IActionResult InsertSchool(School school)
    {
        _repository.Insert<School>(school);
        _repository.Save();
        return Ok();
    }

    [HttpDelete]
    public IActionResult DeleteSchool(int id)
    {
        _repository.Delete<School>(id);
        return Ok();
    }
}