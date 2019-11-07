using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data.Entidades
{
    public class ReporteViewModel
    {
        public int Id { get; set; }

        public string DescripcionVehiculo { get; set; }

        public string NombreCliente { get; set; }

        public string NombreEmpleado { get; set; }

        public string CantidadCombustible { get; set; }

        public bool EstaRayado { get; set; }

        public bool TieneGomaRepuesta { get; set; }

        public bool TieneGato { get; set; }

        public bool TieneCristalRoto { get; set; }

        public bool EstadoGomaDelanteraDerecha { get; set; }

        public bool EstadoGomaDelanteraIzquierda { get; set; }

        public bool EstadoGomaTraseraDerecha { get; set; }

        public bool EstadoGomaTraseraIzquierda { get; set; }

        public DateTime Fecha { get; set; }

        public string EstadoDescripcion { get; set; }
    }
}
