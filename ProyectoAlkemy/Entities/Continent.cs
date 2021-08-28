using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAlkemy.Entities
{
    public class Continent
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Denomination { get; set; }

        public ICollection<City> Cities { get; set; } //Estamos usando una propiedad de navegacion (ICollection) donde Continente va a contener una lista de ciudades.
    }
}
