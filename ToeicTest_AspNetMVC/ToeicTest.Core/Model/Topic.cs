using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToeicTest.Core.Model
{
    [Table("Topic")]
    public class Topic
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public virtual List<Lesson> Lessons { get; set; }
    }
}
