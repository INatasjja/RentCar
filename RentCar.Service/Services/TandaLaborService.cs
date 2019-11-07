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
    public class TandaLaborService : IDataRepo<TandaLabor>
    {
        private readonly ApplicationDbContext _context;

        public TandaLaborService()
        {
            _context = new ApplicationDbContext();
        }

        public TandaLabor Get(int id)
        {
            return _context.TandaLabor.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<TandaLabor> GetAll()
        {
            return _context.TandaLabor.ToList();
        }

        public void Save(TandaLabor model)
        {
            _context.TandaLabor.AddOrUpdate(model);
            _context.SaveChanges();
        }

        public void Delete(TandaLabor model)
        {
            _context.TandaLabor.Remove(_context.TandaLabor.Find(model.Id));
            _context.SaveChanges();
        }
    }
}
