using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data.Entidades
{
    public class ClientViewModel
    {
        public int Id { get; set; }
        
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Cedula { get; set; }
        
        public string TarjetaCredito { get; set; }

        public decimal LimiteCredito { get; set; }

        //public int TipoPersonaId { get; set; }

        public string TipoPersonaDescripcion { get; set; }

        public bool Activo { get; set; }

        //public TipoPersona TipoPersona { get; set; }
    }
}
