using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data
{
    public class VehiculoViewModel
    {
        public int Id { get; set; }
        
        public string Descripcion { get; set; }
        public string NumeroChasis { get; set; }
        public string NumeroMotor { get; set; }
        public string NumeroPlaca { get; set; }

        //public int TipoVehiculoId { get; set; }
        public string TipoVehiculoDescripcion { get; set; }
        //public int MarcaId { get; set; }
        public string MarcaDescripcion { get; set; }
        //public int ModeloId { get; set; }
        public string ModeloDescripcion { get; set; }
        //public int CombustibleId { get; set; }
        public string CombustibleDescrpcion { get; set; }
        //public int EstadoId { get; set; }
        public string EstadoDescripcion { get; set; }

        //public TipoVehiculo TipoVehiculo { get; set; }
        //public Marca Marca { get; set; }
        //public Modelo Modelo { get; set; }
        //public TipoCombustible TipoCombustible { get; set; }
        //public Estado Estado { get; set; }
    }
}
