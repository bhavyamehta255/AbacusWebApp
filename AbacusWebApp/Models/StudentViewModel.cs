using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AbacusWebApp.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Student Name")]
        public string Name { get; set; }
        [EmailAddress]
        [Required]
        [Display(Name = "Email")]
        public string UserName { get; set; }
        
        [Required]
        public string Password { get; set; }
        [Phone]
        [Required]
        [Display(Name = " Contact No")]
        public string Contact { get; set; }

        public string PictureFileName { get; set; }

        public int GroupsId { get; set; }
        public IFormFile PictureFile { get; set; }
        public List<StudentViewModel> StudentList { get; set; }
    }
}
