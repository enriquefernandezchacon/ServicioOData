using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercitoOData.Models
{
    public class Ejercito
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public float FuerzaCombate { get; set; }
        public string Ubicacion { get; set; }
    }
}
