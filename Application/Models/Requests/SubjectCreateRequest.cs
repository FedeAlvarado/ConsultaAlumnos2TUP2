using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Requests
{
    public class SubjectCreateRequest
    {
        public string Name { get; set; }
        public string Quarter { get; set; }

        public static Subject ToEntity(SubjectCreateRequest dto)
        {
            Subject subject = new Subject();
            subject.Name = dto.Name;
            subject.Quarter = dto.Quarter;
            return subject;
        }
    }
}
