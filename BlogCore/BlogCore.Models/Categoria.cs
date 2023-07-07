using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCore.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        /// Nombre
        [Required(ErrorMessage = "Ingrese un nombre para la categoría")]
        [Display(Name = "Nombre Categoría")]
        public string Nombre { get; set; }

        /// Orden
        [Display(Name = "Orden de Visualizción")]
        public int? Orden { get; set; }

    }
}
