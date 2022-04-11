using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToeicTest.Core.Model;

namespace ToeicTest.Core.Service
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=ConnectionString") { }

        public virtual DbSet<Answer> Answers { get; set; }
        public virtual DbSet<Lesson> Lessons { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Topic> Topic { get; set; }
    }
}
