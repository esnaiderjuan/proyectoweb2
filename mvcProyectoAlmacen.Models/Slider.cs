using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mvcProyectoAlmacen.Models
{
    public class Slider
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "ingrese un nombre para el Slider")]
        [Display(Name = "nombre Slider")]

        public string Nombre { get; set; }
        [Required]

        public bool Estado { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Imagen")]

        public string UrlImagen { get; set; }

    }
}
