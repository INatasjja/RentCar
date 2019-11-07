using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data.Entidades
{
    public class ConsultaViewModel
    {
        public int IdRenta { get; set; }

        public string VehiculoDescripcion { get; set; }
        public string TipoVehiculoDescripcion { get; set; }
        public string MarcaDescripcion { get; set; }
        public string ModeloDescripcion { get; set; }
        public string CombustibleDescripcion { get; set; }

        public string VehiculoNumeroChasis { get; set; }
        public string VehiculoNumeroMotor { get; set; }
        public string VehiculoNumeroPlaca { get; set; }

        public string ClienteNombre { get; set; }
        public string ClienteApellido { get; set; }
        public string EmpleadoNombre { get; set; }
        public string EmpleadoApellido { get; set; }

        public DateTime FechaRenta { get; set; }
        public DateTime FechaDevolucion { get; set; }

        public decimal MontoTotal { get; set; }

        public string EstadoVehiculo { get; set; }
    }
}
