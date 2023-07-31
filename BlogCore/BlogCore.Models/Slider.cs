using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BlogCore.Models
{
    public class Slider
    {
        [Key]
        public int Id { get; set; }

        /// Nombre
        [Required(ErrorMessage = "Ingrese un nombre para el slider")]
        [Display(Name = "Nombre Slider")]
        public string Nombre { get; set; }

        /// Estado
        [Required]
        [Display(Name = "Estado")]
        public bool Estado { get; set; }

        /// URL de la imagen
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Imagen")]
        public string UrlImage { get; set; }

    }
}
