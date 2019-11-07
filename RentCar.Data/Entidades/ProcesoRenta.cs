using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data.Entidades
{
    public class ProcesoRenta
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int EmpleadoId { get; set; }
        public int VehiculoId { get; set; }
        public int ClienteId { get; set; }
        public int EstatusRentaId { get; set; }

        [Required]
        public DateTime FechaRenta { get; set; }
        public DateTime FechaDevolucion { get; set; }
        [Required]
        public decimal MontoPorDia { get; set; }
        [Required]
        public int CantidadDias { get; set; }
        [Required]
        public decimal MontoAPagar { get; set; }

        [Required]
        [MaxLength(30)]
        public string Comentario { get; set; }

        public Empleado Empleado { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public Cliente Cliente { get; set; }
        public EstatusRenta EstatusRenta { get; set; }
    }
}
