using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Quarter { get; set; }
        public ICollection<Professor> Professors { get; set;}
        public ICollection<Student> Students { get; set;}
        public ICollection<Question> Questions { get; set;}
    }
}
