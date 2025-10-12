using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Tables
{
    [Table("StudentQuizzes")]
    public class StudentQuiz
    {
        public int Id { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public float? Mark { get; set; }
        [ForeignKey("Student")]
        public int StudentId { get; set; }
        [ForeignKey("Quiz")]
        public int QuizId { get; set; }
        public virtual Student Student { get; set; }
        public virtual Quiz Quiz { get; set; }
    }
}
