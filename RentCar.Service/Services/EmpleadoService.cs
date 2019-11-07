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
    public class EmpleadoService : IDataRepo<Empleado>
    {
        private readonly ApplicationDbContext _context;

        public EmpleadoService()
        {
            _context = new ApplicationDbContext();
        }

        public Empleado Get(int id)
        {
            return _context.Empleado.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Empleado> GetAll()
        {
            return _context.Empleado.ToList();
        }

        public IEnumerable<EmpleadoViewModel> GetEmpleado()
        {
            var EmpleadoView = from a in _context.Empleado
                join b in _context.TandaLabor on a.TandaLaborId equals b.Id
                select new EmpleadoViewModel
                {
                    Id = a.Id,
                    Nombre = a.Nombre,
                    Apellido = a.Apellido,
                    Cedula = a.Cedula,
                    Usuario = a.Usuario,
                    Cargo = a.Cargo,
                    TandaLaborDescripcion = b.Descripcion,
                    PorcientoComision = a.PorcientoComision,
                    FechaIngreso = a.FechaIngreso,
                    Activo = a.Activo
                };

            return EmpleadoView.ToList();
        }

        public void Save(Empleado model)
        {
            _context.Empleado.AddOrUpdate(model);
            _context.SaveChanges();
        }

        public void Delete(Empleado model)
        {
            _context.Empleado.Remove(_context.Empleado.Find(model.Id));
            _context.SaveChanges();
        }
    }
}
