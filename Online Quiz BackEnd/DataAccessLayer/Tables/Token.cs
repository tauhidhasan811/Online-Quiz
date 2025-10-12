using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Tables
{
    public class Token
    {
        public int Id { get; set; }
        [Required]
        public string AccessToken { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        public DateTime? DestroyedAt { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }
        [Required]
        public string Type { get; set; }


    }
}
