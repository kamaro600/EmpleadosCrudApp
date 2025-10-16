using System.ComponentModel.DataAnnotations;

namespace EmpleadosCrudApp.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El usuario es requerido")]
        [StringLength(50, ErrorMessage = "Máximo 50 caracteres")]
        public string Usuario { get; set; } = string.Empty;

        [Required(ErrorMessage = "El email es requerido")]
        [EmailAddress(ErrorMessage = "Formato de email inválido")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "El nombre es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "El cargo es requerido")]
        [StringLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string Cargo { get; set; } = string.Empty;
    }
}