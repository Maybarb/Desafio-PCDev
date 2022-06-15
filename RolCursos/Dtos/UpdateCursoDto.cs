using System.ComponentModel.DataAnnotations;

namespace RolCursos.Dtos
{
    public class UpdateCursoDto
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        public string NomeDoCurso { get; set; }

        [Range(1, 100, ErrorMessage = "A duração minima é de 1H e a máxima de 100H")]
        public int Duracao { get; set; }
    }
}
