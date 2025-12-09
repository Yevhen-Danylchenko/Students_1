using System.ComponentModel.DataAnnotations;


namespace Students.Models
{
    public class Student
    {
        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Range(1, 120)]
        public int Age { get; set; }

        [Required, StringLength(50)]
        public string Group { get; set; } = string.Empty;

        // isGrade: чи є оцінка/підсумок (булеве)
        public bool IsGrade { get; set; }
    }
}
