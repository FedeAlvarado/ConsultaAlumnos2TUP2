using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class SubjectDto
    {
        public string Name { get; set; }
        public string Quarter { get; set; }

        public static SubjectDto ToDto(Subject subject)
        {
            SubjectDto dto = new();
            dto.Name = subject.Name;
            dto.Quarter = subject.Quarter;
            return dto;
        }
    }
}
