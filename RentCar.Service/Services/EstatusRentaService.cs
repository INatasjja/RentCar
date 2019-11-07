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
    public class EstatusRentaService :  IDataRepo<EstatusRenta>
    {
        private readonly ApplicationDbContext _context;

        public EstatusRentaService()
        {
            _context = new ApplicationDbContext();
        }

        public EstatusRenta Get(int id)
        {
            return _context.EstatusRenta.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<EstatusRenta> GetAll()
        {
            return _context.EstatusRenta.ToList();
        }

        public void Save(EstatusRenta model)
        {
            _context.EstatusRenta.AddOrUpdate(model);
            _context.SaveChanges();
        }

        public void Delete(EstatusRenta model)
        {
            _context.EstatusRenta.Remove(_context.EstatusRenta.Find(model.Id));
            _context.SaveChanges();
        }
    }
}
