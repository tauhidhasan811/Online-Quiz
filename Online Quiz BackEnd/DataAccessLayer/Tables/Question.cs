using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Tables
{
    public class Question
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string QuestionType { get; set; }
        [ForeignKey("Quiz")]
        public int QuizId { get; set; }
        public virtual Quiz Quiz { get; set; }
        ICollection<Option> options { get; set; }
    }
}
