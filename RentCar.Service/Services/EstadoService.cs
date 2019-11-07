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
    public class EstadoService : IDataRepo<Estado>
    {
        private readonly ApplicationDbContext _context;

        public EstadoService()
        {
            _context = new ApplicationDbContext();
        }

        public Estado Get(int id)
        {
            return _context.Estado.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Estado> GetAll()
        {
            return _context.Estado.ToList();
        }

        public void Save(Estado model)
        {
            _context.Estado.AddOrUpdate(model);
            _context.SaveChanges();
        }

        public void Delete(Estado model)
        {
            _context.Estado.Remove(_context.Estado.Find(model.Id));
            _context.SaveChanges();
        }
    }
}
