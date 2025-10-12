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
    public class QuizDTO
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
        public int CourseId { get; set; }
        public int FacultyId { get; set; }
        public int Count { get; set; }
        public float Average { get; set; }

        public ICollection<QuestionDTO> Questions { get; set; }
        public ICollection<StudentQuizDTO> studentquiz { get; set; }
    }
}
