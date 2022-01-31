using DbFirstSchool.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DbFirstSchool.Controllers;

[ApiController]
[Route("/api/studentClass")]
public class StudentClassController : ControllerBase
{
    private IGenericRepository _repository;

    public StudentClassController(IGenericRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public IActionResult GetAllStCl()
    {
        return Ok(_repository.GetAll<StudentClass>());
    }

    [HttpPost]
    public IActionResult InsertStCl(StudentClass sc)
    {
        _repository.Insert<StudentClass>(sc);
        _repository.Save();
        return Ok();
    }
}