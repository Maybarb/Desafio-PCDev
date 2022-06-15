using RolCursos.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace RolCursos.Dtos
{
    public class ReadCursoDto : Curso
    {
    
        public DateTime MomentoDaConsulta { get; set; }
    }
}
