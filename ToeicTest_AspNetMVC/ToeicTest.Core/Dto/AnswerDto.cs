using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToeicTest.Core.Dto
{
    public class AnswerDto
    {
        public string Id { get; set; }
        public string QuestionId { get; set; }
        public string Content { get; set; }
    }
}
