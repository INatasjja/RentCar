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
    public class TipoVehiculoService : IDataRepo<TipoVehiculo>
    {
        private readonly ApplicationDbContext _context;

        public TipoVehiculoService()
        {
            _context = new ApplicationDbContext();
        }

        public TipoVehiculo Get(int id)
        {
            return _context.TipoVehiculo.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<TipoVehiculo> GetAll()
        {
            return _context.TipoVehiculo.ToList();
        }

        public void Save(TipoVehiculo model)
        {
            _context.TipoVehiculo.AddOrUpdate(model);
            _context.SaveChanges();
        }

        public void Delete(TipoVehiculo model)
        {
            _context.TipoVehiculo.Remove(_context.TipoVehiculo.Find(model.Id));
            _context.SaveChanges();
        }
    }
}
