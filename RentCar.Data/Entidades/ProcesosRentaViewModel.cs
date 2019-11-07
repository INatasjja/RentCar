using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data.Entidades
{
    public class ProcesosRentaViewModel
    {
        public int Id { get; set; }

        //public int EmpleadoId { get; set; }
        public string EmpleadoNombre { get; set; }
       //public int VehiculoId { get; set; }
        public string VehiculoDescripcion { get; set; }
        //public int ClienteId { get; set; }
        public string ClienteNombre { get; set; }
        //public int EstatusRentaId { get; set; }
        public string EstatusRentaDescripcion { get; set; }
        
        public DateTime FechaRenta { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public decimal MontoPorDia { get; set; }

        public int CantidadDias { get; set; }
        public decimal MontoAPagar { get; set; }

        public string Comentario { get; set; }

        //public Empleado Empleado { get; set; }
        //public Vehiculo Vehiculo { get; set; }
        //public Cliente Cliente { get; set; }
        //public EstatusRenta EstatusRenta { get; set; }
    }
}
