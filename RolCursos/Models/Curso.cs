using System;
using System.ComponentModel.DataAnnotations;

namespace RolCursos.Models
{
    public class Curso
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string NomeDoCurso { get; set; }

        [Range(1, 100, ErrorMessage = "A duração minima é de 1H e a máxima de 100H")]
        public int Duracao { get; set; }
        public Curso()
        {
            Id = Guid.NewGuid();
        }
    }
}
