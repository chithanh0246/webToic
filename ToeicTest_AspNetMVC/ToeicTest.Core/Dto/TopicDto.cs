using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToeicTest.Core.Dto
{
    public class TopicDto
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public List<LessonDto> Lessons { get; set; }
    }
}
