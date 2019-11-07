using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentCar.Data;
using RentCar.Data.Entidades;
using RentCar.Service.Interfaces;

namespace RentCar.Service.Services
{
    public class VehiculoService :  IDataRepo<Vehiculo>
    {
        private readonly ApplicationDbContext _context;

        public VehiculoService()
        {
            _context = new ApplicationDbContext();
        }

        public Vehiculo Get(int id)
        {
            return _context.Vehiculo.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Vehiculo> GetVRent()
        {
            return _context.Vehiculo.ToList();
        }

        public IEnumerable<Vehiculo> GetAll()
        {
            return _context.Vehiculo.Where(x => x.EstadoId == 1).ToList();
        }
        
        public IEnumerable<VehiculoViewModel> GetVehiculo()
        {
            var VehiculoView = from a in _context.Vehiculo
                join b in _context.TipoVehiculo on a.TipoVehiculoId equals b.Id
                join c in _context.Marca on a.MarcaId equals c.Id
                join d in _context.Modelo on a.ModeloId equals d.Id
                join e in _context.TipoCombustible on a.CombustibleId equals e.Id
                join f in _context.Estado on a.EstadoId equals f.Id
                select new VehiculoViewModel
                {
                    Id = a.Id,
                    Descripcion = a.Descripcion,
                    NumeroChasis = a.NumeroChasis,
                    NumeroMotor = a.NumeroMotor,
                    NumeroPlaca = a.NumeroPlaca,
                    TipoVehiculoDescripcion = b.Descripcion,
                    MarcaDescripcion = c.Descripcion,
                    ModeloDescripcion = d.Descripcion,
                    CombustibleDescrpcion = e.Descripcion,
                    EstadoDescripcion = f.Descripcion
                };

            return VehiculoView.ToList();
        }

        public void Save(Vehiculo model)
        {
            _context.Vehiculo.AddOrUpdate(model);
            _context.SaveChanges();
        }

        public void Delete(Vehiculo model)
        {
            _context.Vehiculo.Remove(_context.Vehiculo.Find(model.Id));
            _context.SaveChanges();
        }
    }
}
