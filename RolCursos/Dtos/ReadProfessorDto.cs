using RolCursos.Models;
using System;

namespace RolCursos.Dtos
{
    public class ReadProfessorDto: Professor
    {
        public DateTime MomentoDaConsulta { get; set; }

    }
    
    
}
