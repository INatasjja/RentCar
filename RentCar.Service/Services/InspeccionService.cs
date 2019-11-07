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
    public class InspeccionService : IDataRepo<Inspeccion>
    {
        private readonly ApplicationDbContext _context;

        public InspeccionService()
        {
            _context = new ApplicationDbContext();
        }

        public Inspeccion Get(int id)
        {
            return _context.Inspeccion.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<Inspeccion> GetAll()
        {
            return _context.Inspeccion.ToList();
        }

        public IEnumerable<ReporteViewModel> GetReporte()
        {
            var ReporteView = from a in _context.Inspeccion
                join b in _context.Vehiculo on a.VehiculoId equals b.Id
                join c in _context.Cliente on a.ClienteId equals c.Id
                join d in _context.Empleado on a.EmpleadoId equals d.Id
                join e in _context.Estado on a.EstadoId equals e.Id
                select new ReporteViewModel
                {
                    Id = a.Id,
                    DescripcionVehiculo = b.Descripcion,
                    NombreCliente = c.Nombre,
                    NombreEmpleado = d.Nombre,
                    CantidadCombustible = a.CantidadCombustible,
                    EstaRayado = a.EstaRayado,
                    TieneGomaRepuesta = a.TieneGomaRepuesta,
                    TieneGato = a.TieneGato,
                    TieneCristalRoto = a.TieneCristalRoto,
                    EstadoGomaDelanteraDerecha = a.EstadoGomaDelanteraDerecha,
                    EstadoGomaDelanteraIzquierda = a.EstadoGomaDelanteraIzquierda,
                    EstadoGomaTraseraDerecha = a.EstadoGomaTraseraDerecha,
                    EstadoGomaTraseraIzquierda = a.EstadoGomaTraseraIzquierda,
                    Fecha = a.Fecha,
                    EstadoDescripcion = e.Descripcion
                };

            return ReporteView.ToList();
        }

        public void Save(Inspeccion model)
        {
            _context.Inspeccion.AddOrUpdate(model);
            _context.SaveChanges();
        }

        public void Delete(Inspeccion model)
        {
            _context.Inspeccion.Remove(_context.Inspeccion.Find(model.Id));
            _context.SaveChanges();
        }
    }
}
