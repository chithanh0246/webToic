using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToeicTest.Core.Model
{
    [Table("Question")]
    public class Question
    {
        public string Id { get; set; }
        public string LessonId { get; set; }
        public string ImgPath { get; set; }
        public string Content { get; set; }
        public string AudioPath { get; set; }
        public string CorrectAnswerId { get; set; }

        public virtual List<Answer> Answers { get; set; }
        public virtual Lesson Lesson { get; set; }
    }
}
