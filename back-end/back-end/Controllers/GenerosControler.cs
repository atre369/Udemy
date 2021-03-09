using back_end.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back_end.Controllers
{
    public class GenerosControler
    {
        private readonly IRepositorio repositorio;
        public GenerosControler(IRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

    }
}
