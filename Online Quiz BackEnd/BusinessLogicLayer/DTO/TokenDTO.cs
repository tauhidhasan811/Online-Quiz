using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTO
{
    public class TokenDTO
    {
        public int Id { get; set; }
        [Required]
        public string AccessToken { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }
        public DateTime? DestroyedAt { get; set; }
        public int UserId { get; set; }
        public string Type { get; set; }
    }
}
