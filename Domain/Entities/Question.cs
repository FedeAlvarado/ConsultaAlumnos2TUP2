using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public ICollection<Response> Responses { get; set; }
        public DateTime? LastModificatedDate { get; set; }
        public Subject Subject { get; set; }
        public Student Student { get; set; }
        public Professor AssignedProfessor { get; set; }
    }
}
