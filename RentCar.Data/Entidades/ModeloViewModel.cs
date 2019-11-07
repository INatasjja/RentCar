using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCar.Data.Entidades
{
    public class ModeloViewModel
    {
        public int Id { get; set; }
        
        public String Descripcion { get; set; }

        //public int MarcaId { get; set; }
        public string MarcaDescripcion { get; set; }
        
        //public Marca Marca { get; set; }
    }
}
