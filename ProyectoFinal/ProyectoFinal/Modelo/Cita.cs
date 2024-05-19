using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Modelo
{
    public class Cita
    {
       public int Id {  get; set; }
        public int ClienteId { get; set; }
        virtual public Cliente? Cliente { get; set; }

        [Required(ErrorMessage = "La fecha es obligatoria")]
        [DataType(DataType.DateTime, ErrorMessage = "Ingrese una fecha valida")]
        public DateTime? Fecha { get; set; }
        [Required(ErrorMessage = "La hora es obligartoria")]
        //[DataType(DataType.Time, ErrorMessage = "Ingrese una hora valida")]
        public int? Hora { get; set; }
        public int TerapeutaId { get; set; }
        virtual public Terapeuta? Terapeuta { get; set; }

    }
}
