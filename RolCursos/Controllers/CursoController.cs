using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RolCursos.Dtos;
using RolCursos.Models;
using RolCursos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RolCursos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CursoController : ControllerBase
    {
        private AplicationDbContext _context = new AplicationDbContext();

        [HttpPost]
        public IActionResult AdicionarCurso([FromBody]CreateCursoDto cursoDto)
        {
            Curso curso = new Curso
            {
                NomeDoCurso = cursoDto.NomeDoCurso,
                Duracao = cursoDto.Duracao,
            };
            _context.TabelaDeCursos.Add(curso);
            _context.SaveChanges();
            return Created("curso", curso);
        } 

        [HttpGet]
        public IActionResult ObterCurso() 
        {
            return Ok(_context.TabelaDeCursos);
        }

        [HttpGet("{id}")] 
        public IActionResult ObterCursosPorId(Guid id)
        {
            Curso curso = _context.TabelaDeCursos.FirstOrDefault(curso => curso.Id == id);
            if (curso != null)
            {
                ReadCursoDto cursoDto = new ReadCursoDto
                {
                    NomeDoCurso = curso.NomeDoCurso,
                    Duracao = curso.Duracao,
                    Id = curso.Id,
                    MomentoDaConsulta = DateTime.Now
                };
                return Ok(cursoDto);
            }
            return NotFound();
        }

        [HttpPut("{id}")]
        public IActionResult AtualizarCurso(Guid id, [FromBody] UpdateCursoDto cursoDto)
        {
            Curso curso = _context.TabelaDeCursos.FirstOrDefault(curso => curso.Id == id);
            if(curso == null)
            {
                return NotFound();
            }
            curso.NomeDoCurso = cursoDto.NomeDoCurso;
            curso.Duracao = cursoDto.Duracao;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletarCurso(Guid id)
        {
            Curso curso = _context.TabelaDeCursos.FirstOrDefault(curso => curso.Id == id);
            if (curso == null)
            {
                return NotFound();
            }
            _context.Remove(curso);
            _context.SaveChanges();
            return NoContent();
        }

    }
}
