using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BlogCore.Models
{
    public class Articulo
    {

        [Key]
        public int Id { get; set; }

        /// Nombre
        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "Nombre del artículo")]
        public string Nombre { get; set; }

        /// Descripción
        [Required(ErrorMessage = "La descripción es obligatoria")]
        //[Display(Name = "Descripción del artículo")]
        public string Descripcion { get; set; }

        /// Fecha de creación
        [Display(Name = "Fecha de creación")]
        public string FechaCreacion { get; set; }

        /// URL de la imagen
        [DataType(DataType.ImageUrl)]
        [Display(Name = "Imagen")]
        public string UrlImage { get; set; }

        /// ID de la categoria. Campo ligado
        [Required]
        public int CategoriaId { get; set; }

        [ForeignKey("CategoriaId")]
        public Categoria Categoria { get; set;}

    }
}
