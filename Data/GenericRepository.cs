using DbFirstSchool.Interfaces;

namespace DbFirstSchool;

public class GenericRepository : IGenericRepository
{
    private schoolDBContext _context;

    public GenericRepository(schoolDBContext context)
    {
        _context = context;
    }

    public IEnumerable<T> GetAll<T>() where T : class
    {
        return _context.Set<T>().ToList();
    }

    public void Insert<T>(T obj) where T : class
    {
        _context.Set<T>().Add(obj);
    }

    public void Delete<T>(int id) where T : class
    {
        _context.Remove(id);
    }


    public T GetById<T>(int id) where T : class
    {
        var exist = _context.Set<T>().Find(id);
        return exist;
    }

    public void Save()
    {
        _context.SaveChanges();
    }
}