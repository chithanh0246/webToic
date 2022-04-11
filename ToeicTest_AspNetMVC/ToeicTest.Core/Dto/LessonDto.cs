using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToeicTest.Core.Dto
{
    public class LessonDto
    {
        public string Id { get; set; }
        public string TopicId { get; set; }
        public string Name { get; set; }

        public int TotalQuestions { get; set; }
        public List<QuestionDto> Questions { get; set; }
    }
}
