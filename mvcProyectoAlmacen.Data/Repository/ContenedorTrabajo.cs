using mvcProyectoAlmacen.Data.Repository.IRepository;
using mvcProyectoAlmacen.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvcProyectoAlmacen.Data.Repository;

namespace mvcProyectoAlmacen.Data.Repository
{
    public class ContenedorTrabajo: IContenedorTrabajo
    {
        private readonly ApplicationDbContext _context;
        
        public ContenedorTrabajo(ApplicationDbContext context)
        {
            _context = context;
            //se agregan cada uno de los repositorios para que queden encapsulados
           
            Usuario = new UsuarioRepository(_context);
        }


       public IEmpleadoRepository Empleado { get; set; }
        public IUsuarioRepository Usuario { get; private set; }

        public ISliderRepository Slider { get; set; }
        public void Dispose()
        {
            _context.Dispose();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
