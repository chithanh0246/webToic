using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToeicTest.Core.Model
{
    [Table("Answer")]
    public class Answer
    {
        public string Id { get; set; }
        public string QuestionId { get; set; }
        public string Content { get; set; }

        public virtual Question Question { get; set; }
    }
}
