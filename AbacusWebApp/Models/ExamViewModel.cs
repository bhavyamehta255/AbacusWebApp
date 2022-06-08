using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AbacusWebApp.Models
{
    public class ExamViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = " Exam Name")]
        public int ExamsId { get; set; }
        [Required]
        [Display(Name = " Question")]
        public string Question { get; set; }
        [Required]
        [Display(Name = " Answer")]
        public int Answer { get; set; }
        [Required]
        [Display(Name = " option1")]
        public string Option1 { get; set; }
        [Required]
        [Display(Name = " option2")]
        public string Option2 { get; set; }
        [Required]
        [Display(Name = " option3")]
        public string Option3 { get; set; }
        [Required]
        [Display(Name = " option4")]
        public string Option4 { get; set; }
        public List<ExamViewModel> QnAsList { get; set; }
        public IEnumerable<ExamsLevel> ExamList { get; set; }
    }

    public class ExamsLevel
    {
        public string Level { get; set; }
        public int Id { get; set; }
    }
}
