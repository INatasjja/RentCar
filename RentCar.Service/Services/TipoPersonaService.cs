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
    public class TipoPersonaService : IDataRepo<TipoPersona>
    {
        private readonly ApplicationDbContext _context;

        public TipoPersonaService()
        {
            _context = new ApplicationDbContext();
        }

        public TipoPersona Get(int id)
        {
            return _context.TipoPersona.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<TipoPersona> GetAll()
        {
            return _context.TipoPersona.ToList();
        }

        public void Save(TipoPersona model)
        {
            _context.TipoPersona.AddOrUpdate(model);
            _context.SaveChanges();
        }

        public void Delete(TipoPersona model)
        {
            _context.TipoPersona.Remove(_context.TipoPersona.Find(model.Id));
            _context.SaveChanges();
        }
    }
}
