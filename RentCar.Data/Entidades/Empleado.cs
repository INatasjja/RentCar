using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data.Entidades
{
    public class Empleado
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, MaxLength(30)]
        public string Nombre { get; set; }
        [Required, MaxLength(30)]
        public string Apellido { get; set; }
        [Required, MaxLength(30)]
        public string Cedula { get; set; }
        [Required]
        public string Usuario { get; set; }
        [Required]
        public string Pass { get; set; }
        [Required]
        public bool Cargo { get; set; }
        [Required]
        public int TandaLaborId { get; set; }
        [Required]
        public decimal PorcientoComision { get; set; }
        [Required]
        public DateTime FechaIngreso { get; set; }
        [Required]
        public bool Activo { get; set; }

        public virtual TandaLabor TandaLabor { get; set; }
    }
}
