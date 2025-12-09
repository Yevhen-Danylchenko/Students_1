using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Students.Models;
using Students.Services;

namespace Students.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly IStudentRepository _repository;

        public CreateModel(IStudentRepository repository)
        {
            _repository = repository;
        }

        [BindProperty]
        public Student Student { get; set; } = new();

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            _repository.AddStudent(Student);
            return Redirect("/");
        }
    }
}
