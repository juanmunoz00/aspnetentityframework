using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCore.Models
{
    public class ApplicationUser : IdentityUser
    {
        // Nombre
        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string Nombre { get; set; }

        // Dirección
        [Required(ErrorMessage = "La dirección es obligatoria")]
        public string Direccion { get; set; }

        // Ciudad
        [Required(ErrorMessage = "La ciudad es obligatoria")]
        public string Ciudad { get; set; }

        // País
        [Required(ErrorMessage = "El país es obligatorio")]
        public string Pais { get; set; }

    }
}
