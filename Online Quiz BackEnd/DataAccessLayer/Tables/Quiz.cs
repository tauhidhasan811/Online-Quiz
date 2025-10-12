using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Tables
{
    [Table("Quizzes")]
    public class Quiz
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int TotalMark { get; set; }
        [Required]
        public int Duration { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        [Required]
        public DateTime EndTime { get; set; }
        [ForeignKey("Course")]
        public int CourseId { get; set; }
        [ForeignKey("Faculty")]
        public int FacultyId { get; set; }
        public virtual Course Course { get; set; }
        public virtual Faculty Faculty { get; set; }
        public ICollection<Question> Questions { get; set; }
        public ICollection<StudentQuiz> studentquiz { get; set; }
    }
}
