using Application.Models;
using Application.Models.Requests;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class SubjectService
    {
        private readonly ISubjectRepository _sRepository;
        public SubjectService(ISubjectRepository sRepository)
        {
            _sRepository = sRepository;
        }

        public SubjectDto GetById(int id)
        {
            SubjectDto subjectDto = SubjectDto.ToDto(_sRepository.GetByIdAsync(id).Result ?? throw new Exception("No se encontraron Materias"));
            return subjectDto;
        }

        public SubjectDto Create(SubjectCreateRequest dto)
        {
            return SubjectDto.ToDto(_sRepository.AddAsync(SubjectCreateRequest.ToEntity(dto)).Result);
        }
    }
}
