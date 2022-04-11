using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToeicTest.Core.Dto;

namespace ToeicTest.Core.Service
{
    public class TopicService
    {
        public List<LessonDto> GetLession(string topicId)
        {
            using (var context = new MyContext())
            {
                return context.Lessons
                    .Where(x => x.TopicId.Equals(topicId))
                    .Select(x => new LessonDto()
                    {
                        Id = x.Id,
                        Name = x.Name,
                        TotalQuestions = x.Questions.Count()
                    }).ToList();
            }
        }

        public int GetTotalLession(string topicId)
        {
            using (var context = new MyContext())
            {
                return context.Lessons
                    .Where(x => x.TopicId.Equals(topicId)).Count();
            }
        }
    }
}
