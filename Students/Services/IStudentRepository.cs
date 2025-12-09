using Students.Models;

namespace Students.Services
{
    public class IStudentRepository
    {
        void AddStudent(Student student);
        IEnumerable<Student> GetAllStudents();
    }
}
