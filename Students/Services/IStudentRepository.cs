using Students.Models;

namespace Students.Services
{
    public interface IStudentRepository
    {
        void AddStudent(Student student);
        IEnumerable<Student> GetAllStudents();
    }
}
