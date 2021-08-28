using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAlkemy.Entities
{
    public class City
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Denomination { get; set; }
        public int CantHabitantes { get; set; }
        public decimal SuperfTotal { get; set; }
        public Continent Continent { get; set; } //Definimos propiedad de navegacion por Referencia

        public ICollection<GeographicIcons> GeoIcons { get; set; }
    }
}
