using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Student : User
    {
        public ICollection<Subject> SubjectsAttended { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
