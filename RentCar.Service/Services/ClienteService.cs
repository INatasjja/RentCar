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
    public class ClienteService : IDataRepo<Cliente>
    {
        private readonly ApplicationDbContext _context;

        public ClienteService()
        {
            _context = new ApplicationDbContext();
        }

        public Cliente Get(int id)
        {
            return _context.Cliente.SingleOrDefault(x => x.Id == id);
        }
        
        public IEnumerable<Cliente> GetAvalible()
        {
            return _context.Cliente.Where(x => x.Activo == true).ToList();
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _context.Cliente.ToList();
        }

        public IEnumerable<ClientViewModel> GetClient()
        {
            var ClienteView = from a in _context.Cliente
                join b in _context.TipoPersona on a.TipoPersonaId equals b.Id
                select new ClientViewModel
                {
                    Id = a.Id,
                    Nombre = a.Nombre,
                    Apellido = a.Apellido,
                    Cedula = a.Cedula,
                    TipoPersonaDescripcion = b.Descripcion,
                    TarjetaCredito = a.TarjetaCredito,
                    LimiteCredito = a.LimiteCredito,
                    Activo = a.Activo
                };

            return ClienteView.ToList();
        }

        public void Save(Cliente model)
        {
            _context.Cliente.AddOrUpdate(model);
            _context.SaveChanges();
        }

        public void Delete(Cliente model)
        {
            _context.Cliente.Remove(_context.Cliente.Find(model.Id));
            _context.SaveChanges();
        }
    }
}
