using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer
{
    public class UserDTO
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public int? StudentId { get; set; }
        public int? FacultyId { get; set; }
        [Required]
        public string Type { get; set; }
    }
}
