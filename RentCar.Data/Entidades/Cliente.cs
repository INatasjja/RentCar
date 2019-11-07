using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data.Entidades
{
    public class Cliente
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }
        [Required]
        [MaxLength(30)]
        public string Apellido { get; set; }
        [Required]
        [MaxLength(30)] 
        public string Cedula { get; set; }

        [Required]
        [MaxLength(30)]
        public string TarjetaCredito { get; set; }
        [Required]
        public decimal LimiteCredito { get; set; }

        public int TipoPersonaId { get; set; }
        [Required]
        public bool Activo { get; set; }
        
        public TipoPersona TipoPersona { get; set; }
    }
}
