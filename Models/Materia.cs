using System.ComponentModel.DataAnnotations;

namespace concurso_p2024.Models
{
    public class Materia
    {
        [Key]
        [Required(ErrorMessage = "El campo Id es requerido")]
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Nombre es requerido")]
        [StringLength(50, ErrorMessage = "El campo Nombre no puede tener más de 50 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El campo Creditos es requerido")]
        [Range(1, 10, ErrorMessage = "El campo Creditos debe ser un número entre 1 y 10")]
        public int Creditos { get; set; }
    }
}
