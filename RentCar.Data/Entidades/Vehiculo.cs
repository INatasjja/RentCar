using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data.Entidades
{
    public class Vehiculo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(50)]
        public string Descripcion { get; set; } 
        [Required]
        [MaxLength(15)]
        public string NumeroChasis { get; set; }
        [Required]
        [MaxLength(15)]
        public string NumeroMotor { get; set; }
        [Required]
        [MaxLength(15)]
        public string NumeroPlaca { get; set; }
        
        public int TipoVehiculoId { get; set; }
        public int MarcaId { get; set; }
        public int ModeloId { get; set; }
        public int CombustibleId { get; set; }
        public int EstadoId { get; set; }
        
        public TipoVehiculo TipoVehiculo { get; set; }
        public Marca Marca { get; set; }
        public Modelo Modelo { get; set; }
        public TipoCombustible TipoCombustible { get; set; }
        public Estado Estado { get; set; }

    }
}
