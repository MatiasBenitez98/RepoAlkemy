using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAlkemy.Entities
{
    public class GeographicIcons
    {
        public int Id { get; set; }// propiedad escalable o primitiva que corresponde con el modelo de bd
        public string Image { get; set; }
        public string Denomination { get; set; }
        public DateTime CreationDate { get; set; }
        public int Height { get; set; }
        public string History { get; set; }
        public City City { get; set; }
    }
}
