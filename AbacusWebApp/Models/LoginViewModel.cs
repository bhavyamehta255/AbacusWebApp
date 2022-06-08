using System.ComponentModel.DataAnnotations;

namespace AbacusWebApp.Models
{
    public class LoginViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string pasword { get; set; }
        public int Role { get; set; }
        public int CityID { get; set; }
    }
}
