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
    public class StudentQuizDTO
    {
        public int Id { get; set; }
        [Required]
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public float? Mark { get; set; }
        public int StudentId { get; set; }
        public int QuizId { get; set; }
    }
}
