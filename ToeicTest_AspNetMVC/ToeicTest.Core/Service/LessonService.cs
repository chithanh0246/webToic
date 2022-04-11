using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToeicTest.Core.Dto;

namespace ToeicTest.Core.Service
{
    public class LessonService
    {
        public LessonDto GetById(string lessionId)
        {
            using (var context = new MyContext())
            {
                return context.Lessons
                    .Where(x => x.Id.Equals(lessionId))
                    .Select(x => new LessonDto()
                    {
                        Id = x.Id,
                        Name = x.Name
                    }).FirstOrDefault();
            }
        }
        public List<QuestionDto> GetQuestion(string lessionId)
        {
            using (var context = new MyContext())
            {
                return context.Questions
                    .Where(x => x.LessonId.Equals(lessionId))
                    .Select(x => new QuestionDto()
                    {
                        Id = x.Id,
                        AudioPath = x.AudioPath,
                        ImgPath = x.ImgPath,
                        Content = x.Content,
                        CorrectAnswerId = x.CorrectAnswerId,
                        Answers = x.Answers.OrderBy(y => y.Content).Select(y => new AnswerDto()
                        {
                            Id = y.Id,
                            Content = y.Content
                        }).ToList()
                    }).ToList();
            }
        }
    }
}