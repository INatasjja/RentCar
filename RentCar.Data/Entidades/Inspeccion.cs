using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data.Entidades
{
    public class Inspeccion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int VehiculoId { get; set; }
        public int ClienteId { get; set; }
        public int EmpleadoId { get; set; }

        [Required]
        [MaxLength(15)]
        public string CantidadCombustible { get; set; }
        
        [Required]
        public bool EstaRayado { get; set; }
        [Required]
        public bool TieneGomaRepuesta { get; set; }
        [Required]
        public bool TieneGato { get; set; }
        [Required]
        public bool TieneCristalRoto { get; set; }
        [Required]
        public bool EstadoGomaDelanteraDerecha { get; set; }
        [Required]
        public bool EstadoGomaDelanteraIzquierda { get; set; }
        [Required]
        public bool EstadoGomaTraseraDerecha { get; set; }
        [Required]
        public bool EstadoGomaTraseraIzquierda { get; set; }
        [Required]
        public DateTime Fecha { get; set; }

        public int EstadoId { get; set; }
        
        public Vehiculo Vehiculo { get; set; }
        public Cliente Cliente { get; set; }
        public Empleado Empleado { get; set; }
        public Estado Estado { get; set; }

    }
}
