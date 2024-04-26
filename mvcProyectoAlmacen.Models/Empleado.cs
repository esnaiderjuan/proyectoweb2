using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcProyectoAlmacen.Models
{
    public class Empleado
    {
        [Key]
        public int IdEmpleado { get; set; }
        public string NombreEmpleado { get; set; }
        public string ApellidoEmpleado { get; set; }
       
        public string Cargo { get; set; }
    }
}
