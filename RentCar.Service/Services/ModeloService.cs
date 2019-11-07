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
    public class ModeloService : IDataRepo<Modelo>
    {
        private readonly ApplicationDbContext _context;

        public ModeloService()
        {
            _context = new ApplicationDbContext();
        }

        public Modelo Get(int id)
        {
            return _context.Modelo.SingleOrDefault(x => x.Id == id);
        }
        public IEnumerable<ModeloViewModel> GetModelo()
        {
            var ModeloView = from a in _context.Modelo
                join b in _context.Marca on a.MarcaId equals b.Id
                select new ModeloViewModel
                {
                    Id = a.Id,
                    Descripcion = a.Descripcion,
                    MarcaDescripcion = b.Descripcion,
                };

            return ModeloView.ToList();
        }

        public IEnumerable<KeyValuePair<int, String>> Join()
        {
            return (from a in _context.Modelo
                    join b in _context.Marca on a.MarcaId equals b.Id
                    select new {Key = a.Id, Value = a.Descripcion }).ToList().
                    Select(x=> new KeyValuePair<int, String>(x.Key,x.Value)).ToList();
        }

        public IEnumerable<Modelo> GetAll()
        {
            return _context.Modelo.ToList();
        }

        public void Save(Modelo model)
        {
            _context.Modelo.AddOrUpdate(model);
            _context.SaveChanges();
        }

        public void Delete(Modelo model)
        {
            _context.Modelo.Remove(_context.Modelo.Find(model.Id));
            _context.SaveChanges();
        }
    }
}
