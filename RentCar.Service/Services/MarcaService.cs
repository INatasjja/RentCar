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
    public class MarcaService : IDataRepo<Marca>
    {
        private readonly ApplicationDbContext _context;

        public MarcaService()
        {
            _context = new ApplicationDbContext();
        }

        public Marca Get(int id)
        {
            return _context.Marca.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Marca> GetAll()
        {
            return _context.Marca.ToList();
        }

        public void Save(Marca model)
        {
            _context.Marca.AddOrUpdate(model);
            _context.SaveChanges();
        }

        public void Delete(Marca model)
        {
            _context.Marca.Remove(_context.Marca.Find(model.Id));
            _context.SaveChanges();
        }
    }
}
