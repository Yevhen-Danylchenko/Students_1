using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Students.Services;
using System.Text;

namespace Students.Pages.Students
{
    public class ExportModel : PageModel
    {
        private readonly IStudentRepository _repository;

        public ExportModel(IStudentRepository repository)
        {
            _repository = repository;
        }

        public IActionResult OnGet()
        {
            var students = _repository.GetAllStudents();
            var sb = new StringBuilder();
            sb.AppendLine("Name,Age,Group,IsGrade");

            foreach (var s in students)
                sb.AppendLine($"{s.Name},{s.Age},{s.Group},{s.IsGrade}");

            return File(Encoding.UTF8.GetBytes(sb.ToString()), "text/csv", "students.csv");
        }
    }
}
