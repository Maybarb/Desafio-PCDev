using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RolCursos.Dtos;
using RolCursos.Models;
using RolCursos.Repository;
using System;
using System.Linq;

namespace RolCursos.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProfessorController : ControllerBase
    {
        private AplicationDbContext _context = new AplicationDbContext();

        [HttpPost]
        public IActionResult AdicionarProfessor([FromBody] CreateProfessorDto professorDto)
        {
            Professor professor = new Professor
            {
                NomeProfessor = professorDto.NomeProfessor,
                Curso = professorDto.Curso,
            };
            _context.TabelaDeProfessores.Add(professor);
            _context.SaveChanges();
            return Created("professor", professor);
        }

        [HttpGet]
        public IActionResult ObterProfessor()
        {
            return Ok(_context.TabelaDeProfessores);
        }

        [HttpGet("{id}")]
        public IActionResult ObterProfessorPorId(Guid id)
        {
            Professor professor = _context.TabelaDeProfessores.FirstOrDefault(professor => professor.Id == id);
            if (professor != null)
            {
                ReadProfessorDto professorDto = new ReadProfessorDto
                {
                    NomeProfessor = professor.NomeProfessor,
                    Curso = professor.Curso,
                    Id = professor.Id,
                    MomentoDaConsulta = DateTime.Now
                };
                return Ok(professorDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarProfessor(Guid id, [FromBody] UpdateProfessorDto professorDto)
        {
            Professor professor = _context.TabelaDeProfessores.FirstOrDefault(professor => professor.Id == id);
            if (professor == null)
            {
                return NotFound();
            }
            professor.NomeProfessor = professorDto.NomeProfessor;
            professor.Curso = professorDto.Curso;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarProfessor(Guid id)
        {
            Professor professor = _context.TabelaDeProfessores.FirstOrDefault(professor => professor.Id == id);
            if (professor == null)
            {
                return NotFound();
            }
            _context.Remove(professor);
            _context.SaveChanges();
            return NoContent();
        }

    }
}
