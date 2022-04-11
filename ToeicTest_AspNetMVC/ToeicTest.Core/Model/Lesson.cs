using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToeicTest.Core.Model
{
    [Table("Lesson")]
    public class Lesson
    {
        public string Id { get; set; }
        public string TopicId { get; set; }
        public string Name { get; set; }

        public virtual Topic Topic { get; set; }
        public virtual List<Question> Questions { get; set; }
    }
}
