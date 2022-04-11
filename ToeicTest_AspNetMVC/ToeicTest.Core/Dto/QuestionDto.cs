using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToeicTest.Core.Dto
{
    public class QuestionDto
    {
        public string Id { get; set; }
        public string LessonId { get; set; }
        public string ImgPath { get; set; }
        public string Content { get; set; }
        public string AudioPath { get; set; }
        public string CorrectAnswerId { get; set; }

        public List<AnswerDto> Answers { get; set; }

        /// <summary>
        /// Đáp án user đã chọn
        /// </summary>
        public string UserAnswer { get; set; }
    }
}
