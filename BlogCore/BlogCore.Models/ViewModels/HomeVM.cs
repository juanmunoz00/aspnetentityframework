using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCore.Models.ViewModels
{
    public class HomeVM
    {
        //public Articulo Articulo { get; set; } // Modelo desplegable
        public IEnumerable<Slider> Slider { get; set; }
        public IEnumerable<Articulo> ListaArticulos { get; set; } // Lista desplegable de categorías

    }
}
