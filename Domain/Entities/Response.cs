using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Response
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public User UserCreation { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public Question Question { get; set; }
    }
}
