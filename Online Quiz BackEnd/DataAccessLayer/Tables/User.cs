using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Tables
{
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }    
        [Required]
        public string Password { get; set; }
        [ForeignKey("Student")]
        public int? StudentId { get; set; }
        [ForeignKey("Faculty")]
        public int? FacultyId { get; set; }
        [Required]
        public string Type { get; set; }
        public virtual Faculty Faculty { get; set; }
        public virtual Student Student { get; set; }
    }
}
