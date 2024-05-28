using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Professor : User
    {
        public ICollection<Subject> Subjects { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
