using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Entities
{
    public class PeliculaConDirector
    {
        public int Id { get; set; }
        public string Nombre_Pelicula { get; set; }
        public int Lanzamiento { get; set; }
        public int Cantidad_Disponible { get; set; }

        public int Id_Director { get; set; }
        public Director Director { get; set; }

        public int Id_Genero { get; set; }

        public Genero Genero { get; set; }


    }
}
