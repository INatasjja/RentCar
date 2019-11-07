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
    public class ProcesoRentaService : IDataRepo<ProcesoRenta>
    {
        private readonly ApplicationDbContext _context;

        public ProcesoRentaService()
        {
            _context = new ApplicationDbContext();
        }

        public ProcesoRenta Get(int id)
        {
            return _context.ProcesoRenta.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<ProcesoRenta> GetAll()
        {
            return _context.ProcesoRenta.ToList();
        }

        public IEnumerable<ConsultaViewModel> GetConsulta()
        {
            var ConsultaView = from a in _context.ProcesoRenta
                join b in _context.Vehiculo on a.VehiculoId equals b.Id
                join c in _context.Cliente on a.ClienteId equals c.Id
                join d in _context.Empleado on a.EmpleadoId equals d.Id
                join e in _context.TipoVehiculo on b.TipoVehiculoId equals e.Id
                join f in _context.TipoCombustible on b.CombustibleId equals f.Id
                join g in _context.EstatusRenta on b.EstadoId equals g.Id
                select new ConsultaViewModel
                {
                    IdRenta = a.Id,
                    VehiculoDescripcion = b.Descripcion,
                    TipoVehiculoDescripcion = e.Descripcion,
                    MarcaDescripcion = b.Marca.Descripcion,
                    ModeloDescripcion = b.Modelo.Descripcion,
                    CombustibleDescripcion = f.Descripcion,
                    VehiculoNumeroChasis = b.NumeroChasis,
                    VehiculoNumeroMotor = b.NumeroMotor,
                    VehiculoNumeroPlaca = b.NumeroPlaca,
                    ClienteNombre = c.Nombre,
                    ClienteApellido = c.Apellido,
                    EmpleadoNombre = d.Nombre,
                    EmpleadoApellido = d.Apellido,
                    FechaRenta = a.FechaRenta,
                    FechaDevolucion = a.FechaDevolucion,
                    MontoTotal = a.MontoAPagar,
                    EstadoVehiculo = g.Descripcion
                };

            return ConsultaView.ToList();
        }

        public IEnumerable<ProcesosRentaViewModel> GetRenta()
        {
            var RentaView = from a in _context.ProcesoRenta
                join b in _context.Empleado on a.EmpleadoId equals b.Id
                join c in _context.Vehiculo on a.VehiculoId equals c.Id
                join d in _context.Cliente on a.ClienteId equals d.Id
                join e in _context.EstatusRenta on a.EstatusRentaId equals e.Id
                select new ProcesosRentaViewModel
                {
                    Id = a.Id,
                    EmpleadoNombre = b.Nombre,
                    VehiculoDescripcion = c.Descripcion,
                    ClienteNombre = d.Nombre,
                    FechaRenta = a.FechaRenta,
                    FechaDevolucion = a.FechaDevolucion,
                    MontoPorDia = a.MontoPorDia,
                    CantidadDias = a.CantidadDias,
                    MontoAPagar = a.MontoAPagar,
                    Comentario = a.Comentario,
                    EstatusRentaDescripcion = e.Descripcion
                };

            return RentaView.ToList();
        }

        public void Save(ProcesoRenta model)
        {try
            {
                _context.ProcesoRenta.AddOrUpdate(model);
                _context.SaveChanges();
            }
            catch (Exception e) { Console.WriteLine(e); }
        }

        public void Delete(ProcesoRenta model)
        {
            _context.ProcesoRenta.Remove(_context.ProcesoRenta.Find(model.Id));
            _context.SaveChanges();
        }
    }
}
