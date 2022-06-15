using System;
using System.ComponentModel.DataAnnotations;

namespace RolCursos.Models
{
    public class Professor
    {
        
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo NomeDoProfesor é obrigatório")]
        public string NomeProfessor { get; set; }
        //public Curso Curso { get; set; }
        public string Curso { get; set; }

        public Professor()
        {
            Id = Guid.NewGuid();
        }

       

    }
}
