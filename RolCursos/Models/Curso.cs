using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RolCursos.Models
{
    public class Curso
    {
        [Key]
        [Required]
       
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string NomeDoCurso { get; set; }

        [Range(1, 100, ErrorMessage = "A duração minima é de 1H e a máxima de 100H")]
        public int Duracao { get; set; }
        //public virtual Professor Professor { get; set; }

        //[ForeignKey("Professor")]
        //public int ProfessorId { get; set; }
        public Curso()
        {
            Id = Guid.NewGuid();
        }
    }
}
