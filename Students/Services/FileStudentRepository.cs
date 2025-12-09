using System.Text.Json;
using Students.Models;

namespace Students.Services
{
    public class FileStudentRepository : IStudentRepository
    {
        private readonly string _filePath = Path.Combine("Data", "students.json");

        public void AddStudent(Student student)
        {
            List<Student> students = new();

            if (File.Exists(_filePath))
            {
                var json = File.ReadAllText(_filePath);
                students = JsonSerializer.Deserialize<List<Student>>(json) ?? new List<Student>();
            }

            students.Add(student);
            File.WriteAllText(_filePath, JsonSerializer.Serialize(students, new JsonSerializerOptions { WriteIndented = true }));
        }

        public IEnumerable<Student> GetAllStudents()
        {
            if (!File.Exists(_filePath))
                return new List<Student>();

            var json = File.ReadAllText(_filePath);
            return JsonSerializer.Deserialize<List<Student>>(json) ?? new List<Student>();
        }
    }
}
