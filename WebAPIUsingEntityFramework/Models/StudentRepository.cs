using WebAPIUsingEntityFramework.Interface;

namespace WebAPIUsingEntityFramework.Models
{
    public class StudentRepository : Istudent
    {

        private StudentsContext _context;
        public StudentRepository(StudentsContext context)
        {
            _context = context;
        }
        public Student Add(Student student)
        {
            if (student == null)
            {
                throw new NotImplementedException("student");
            }
            student.Id = student.Id;
            student.FirstName = student.FirstName;
            student.LastName = student.LastName;
            student.Email = student.Email;
            student.PhoneNumber = student.PhoneNumber;
            student.Age = student.Age;
            _context.students.Add(student);
            _context.SaveChanges();
            return student;
        }

        public bool Delete(int id)
        {
            var stu = _context.students.FirstOrDefault(x => x.Id == id);
            if (stu != null)
            {
                _context.students.Remove(stu);
                _context.SaveChanges();
                return true;
            }
            else
                return false;
        }

        public List<Student> Get()
        {
            return _context.students.ToList();
        }
        public IEnumerable<Student> GetAll()
        {
            _context.SaveChanges();
            return _context.students;
        }

        public Student Get(int id)
        {
            Student stu = _context.students.Find((long)id);
            return stu;
        }



        public bool Update(Student student)
        {

            var students = _context.students.Where(s => s.Id == student.Id).FirstOrDefault();
            if (students == null)
            {

                return false;
            }
            student.Id = student.Id;
            student.FirstName = student.FirstName;
            student.LastName = student.LastName;
            student.Email = student.Email;
            student.PhoneNumber = student.PhoneNumber;
            student.Age = student.Age;      
            _context.SaveChanges();
            return true;
        }
    }
}
