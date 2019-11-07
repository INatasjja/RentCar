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
    public class TipoCombustibleService : IDataRepo<TipoCombustible>
    {
        private readonly ApplicationDbContext _context;

        public TipoCombustibleService()
        {
            _context = new ApplicationDbContext();
        }

        public TipoCombustible Get(int id)
        {
            return _context.TipoCombustible.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<TipoCombustible> GetAll()
        {
            return _context.TipoCombustible.ToList();
        }

        public void Save(TipoCombustible model)
        {
            _context.TipoCombustible.AddOrUpdate(model);
            _context.SaveChanges();
        }

        public void Delete(TipoCombustible model)
        {
            _context.TipoCombustible.Remove(_context.TipoCombustible.Find(model.Id));
            _context.SaveChanges();
        }
    }
}
