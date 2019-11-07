using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data.Entidades
{
     public class EmpleadoViewModel
    {
        public int Id { get; set; }
        
        public string Nombre { get; set; }

        public string Apellido { get; set; }

        public string Cedula { get; set; }

        public string Usuario { get; set; }

        //public string Pass { get; set; }

        public bool Cargo { get; set; }

        //public int TandaLaborId { get; set; }

        public string TandaLaborDescripcion { get; set; }

        public decimal PorcientoComision { get; set; }

        public DateTime FechaIngreso { get; set; }
    
        public bool Activo { get; set; }

        //public TandaLabor TandaLabor { get; set; }
    }
}
