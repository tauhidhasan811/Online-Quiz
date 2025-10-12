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
    public class QuestionDTO
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string QuestionType { get; set; }
        [Required]
        public int QuizId { get; set; }
    }
}
