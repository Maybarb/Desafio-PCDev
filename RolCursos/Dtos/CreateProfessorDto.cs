using System.ComponentModel.DataAnnotations;

namespace RolCursos.Dtos
{
    public class CreateProfessorDto
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string NomeProfessor { get; set; }
        public string Curso { get; set; }
    }
}
