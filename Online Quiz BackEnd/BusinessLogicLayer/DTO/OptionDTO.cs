using DataAccessLayer.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.DTO
{
    public class OptionDTO
    {
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        public int QuestionId { get; set; }
        [Required]
        public bool IsCorrect { get; set; }
    }
}
