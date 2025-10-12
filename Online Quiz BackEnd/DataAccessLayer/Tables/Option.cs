using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Tables
{
    public class Option
    {
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [ForeignKey("Question")]
        public int QuestionId { get; set; }
        [Required]
        public bool IsCorrect { get; set; } = false;
        public virtual Question Question { get; set; }
    }
}
