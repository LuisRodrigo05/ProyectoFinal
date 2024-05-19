using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Modelo
{
    public class Cliente
    {
        public int Id {  get; set; }

        [Required(ErrorMessage = "El Nombre es obligatorio")]
        [StringLength(100, ErrorMessage = "Excede el máximo de caracteres")]
        public string? Nombre { get; set; }
        
        [Required(ErrorMessage = "El Correo es obligatorio")]
        [EmailAddress(ErrorMessage = "El correo no es valido")]
        public string? Correo { get; set; }

        [Required(ErrorMessage = "El Teléfono es obligatorio")]
        [Length(10, 10, ErrorMessage = "El Teléfono debe contener 10 caracteres")]
        public string? Telefono { get; set; }

        [Required(ErrorMessage = "La edad es obligatoria")]
        [Range(0, 100, ErrorMessage = "La edad debe ser un numero entero")]
        public int? Edad {  get; set; }

        [Required(ErrorMessage = "La direccion es obligatoria")]
        [StringLength(100, ErrorMessage = "Excede el máximo de caracteres")]
        public string? Direccion {  get; set; }
        virtual public ICollection<Cita>? Citas { get; set; }
    }
}
