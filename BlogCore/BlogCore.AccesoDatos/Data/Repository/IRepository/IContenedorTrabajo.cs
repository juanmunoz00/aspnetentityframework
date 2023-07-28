using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogCore.AccesoDatos.Data.Repository.IRepository
{
    public interface IContenedorTrabajo : IDisposable
    {
        ICategoriaRepository Categoria { get; }
        //Aqui se deben de ir agregando los diferentes repositorios
        IArticuloRepository Articulo { get; }

        ISliderRepository Slider { get; }

        void Save();
    }
}
