using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ToeicTest.Core.Dto;
using ToeicTest.Core.Service;

namespace ToeicTest.Web.Controllers
{
    public class HomeController : Controller
    {
        public TopicService topicService;
        public LessonService lessionService;

        public ActionResult Index()
        {
            this.topicService = new TopicService();
            ViewBag.totalLessionOfPart1 = this.topicService.GetTotalLession("part1");
            ViewBag.totalLessionOfPart2 = this.topicService.GetTotalLession("part2");
            ViewBag.totalLessionOfPart5 = this.topicService.GetTotalLession("part5");
            return View();
        }

        public ActionResult Part1()
        {
            this.topicService = new TopicService();
            List<LessonDto> lessons = this.topicService.GetLession("part1");
            return View(lessons);
        }

        public ActionResult Part2()
        {
            this.topicService = new TopicService();
            List<LessonDto> lessons = this.topicService.GetLession("part2");
            return View(lessons);
        }

        public ActionResult Part5()
        {
            this.topicService = new TopicService();
            List<LessonDto> lessons = this.topicService.GetLession("part5");
            return View(lessons);
        }

        public ActionResult Help()
        {
            return View();
        }

        public ActionResult PracticePart1(string lessionId)
        {
            this.lessionService = new LessonService();
            LessonDto lesson = this.lessionService.GetById(lessionId);
            List<QuestionDto> questions = this.lessionService.GetQuestion(lessionId);

            ViewData["lesson"] = lesson;
            return View(questions);
        }

        public ActionResult PracticePart2(string lessionId)
        {
            this.lessionService = new LessonService();
            LessonDto lesson = this.lessionService.GetById(lessionId);
            List<QuestionDto> questions = this.lessionService.GetQuestion(lessionId);

            ViewData["lesson"] = lesson;
            return View(questions);
        }

        public ActionResult PracticePart5(string lessionId)
        {
            this.lessionService = new LessonService();
            LessonDto lesson = this.lessionService.GetById(lessionId);
            List<QuestionDto> questions = this.lessionService.GetQuestion(lessionId);

            ViewData["lesson"] = lesson;
            return View(questions);
        }

        [HttpPost]
        public ActionResult ResultPart1(string lessionId, List<QuestionDto> questions)
        {
            this.lessionService = new LessonService();
            LessonDto lesson = this.lessionService.GetById(lessionId);
            List<QuestionDto> allQuestions = this.lessionService.GetQuestion(lessionId);

            foreach (var item in allQuestions)
            {
                var answer = questions.FirstOrDefault(x => x.Id == item.Id);
                if (answer != null)
                {
                    item.UserAnswer = answer.UserAnswer;
                }
            }

            ViewData["lesson"] = lesson;
            return View(allQuestions);
        }

        [HttpPost]
        public ActionResult ResultPart2(string lessionId, List<QuestionDto> questions)
        {
            this.lessionService = new LessonService();
            LessonDto lesson = this.lessionService.GetById(lessionId);
            List<QuestionDto> allQuestions = this.lessionService.GetQuestion(lessionId);

            foreach (var item in allQuestions)
            {
                var answer = questions.FirstOrDefault(x => x.Id == item.Id);
                if (answer != null)
                {
                    item.UserAnswer = answer.UserAnswer;
                }
            }

            ViewData["lesson"] = lesson;
            return View(allQuestions);
        }

        [HttpPost]
        public ActionResult ResultPart5(string lessionId, List<QuestionDto> questions)
        {
            this.lessionService = new LessonService();
            LessonDto lesson = this.lessionService.GetById(lessionId);
            List<QuestionDto> allQuestions = this.lessionService.GetQuestion(lessionId);

            foreach (var item in allQuestions)
            {
                var answer = questions.FirstOrDefault(x => x.Id == item.Id);
                if (answer != null)
                {
                    item.UserAnswer = answer.UserAnswer;
                }
            }

            ViewData["lesson"] = lesson;
            return View(allQuestions);
        }
    }
}