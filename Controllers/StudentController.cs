using DbFirstSchool.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DbFirstSchool.Controllers;

[ApiController]
[Route("api/student")]
public class StudentController : ControllerBase
{
    private IGenericRepository _repository;

    public StudentController(IGenericRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public IActionResult GetAllStudents()
    {
        return Ok(_repository.GetAll<Student>());
    }

    [HttpPost]
    public IActionResult InsertStudent(Student student)
    {
        _repository.Insert<Student>(student);
        _repository.Save();
        return Ok();
    }

    [HttpDelete]
    public IActionResult DeleteStudent(int id)
    {
        _repository.Delete<Student>(id);
        _repository.Save();
        return Ok();
    } 
}