using mvcProyectoAlmacen.Models;
using mvcProyectoAlmacen.Data.Repository.IRepository;
using mvcProyectoAlmacen.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcProyectoAlmacen.Data.Repository
{
    public class EmpleadoRepository : Repository<Empleado>, IEmpleadoRepository
    {
        private readonly ApplicationDbContext db;
        public EmpleadoRepository(ApplicationDbContext _db) : base(_db)
        {
            db = _db;
        }
        public void Update(Empleado empleado)
        {
            var objDesdeDb = db.Empleados.FirstOrDefault(s => s.IdEmpleado == empleado.IdEmpleado);
            objDesdeDb.NombreEmpleado = empleado.NombreEmpleado;
            objDesdeDb.ApellidoEmpleado = empleado.ApellidoEmpleado;
            objDesdeDb.Cargo = empleado.Cargo;

        }
    }
}
