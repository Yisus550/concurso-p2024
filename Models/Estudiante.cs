using System.ComponentModel.DataAnnotations;

namespace concurso_p2024.Models
{
	public class Estudiante
	{
		[Key]
		[Required(ErrorMessage = "El campo Id es requerido")]
		public int Id { get; set; }

		[Required(ErrorMessage = "El campo Nombre es requerido")]
		[StringLength(50, ErrorMessage = "El campo Nombre no puede tener más de 50 caracteres")]
		public string Nombre { get; set; }

		[Required(ErrorMessage = "El campo Apellido es requerido")]
		[StringLength(50, ErrorMessage = "El campo Apellido no puede tener más de 50 caracteres")]
		public string Apellido { get; set; }

		[Required(ErrorMessage = "El campo FechaNacimiento es requerido")]
		[DataType(DataType.DateTime)]
		public DateTime FechaNacimiento { get; set; }
	}
}
