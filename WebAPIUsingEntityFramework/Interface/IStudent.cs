using WebAPIUsingEntityFramework.Models;

namespace WebAPIUsingEntityFramework.Interface
{
    public interface Istudent
    {
        IEnumerable<Student> GetAll();
        Student Add(Student student);
        Student Get(int id);
        bool Update(Student student);
        bool Delete(int id);
    }
}
