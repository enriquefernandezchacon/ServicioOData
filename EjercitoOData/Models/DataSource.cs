using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EjercitoOData.Models
{
    public static class DataSource
    {
        private static IList<Ejercito> _ejercitos { get; set; }

        public static IList<Ejercito> GetEjercitos()
        {
            if (_ejercitos != null)
            {
                return _ejercitos;
            }

            _ejercitos = new List<Ejercito>();

            _ejercitos.Add(new Ejercito()
            {
                Id = 1,
                Nombre = "Equipo A",
                FechaNacimiento = DateTime.Now,
                FuerzaCombate = 1000,
                Ubicacion = "Canarias"
            });

            _ejercitos.Add(new Ejercito()
            {
                Id = 2,
                Nombre = "Todos cojos",
                FechaNacimiento = DateTime.Now,
                FuerzaCombate = 14,
                Ubicacion = "Loja (Granada)"
            });

            _ejercitos.Add(new Ejercito()
            {
                Id = 3,
                Nombre = "Ay Mi Madre",
                FechaNacimiento = DateTime.Now,
                FuerzaCombate = 25,
                Ubicacion = "Madrid"
            });

            _ejercitos.Add(new Ejercito()
            {
                Id = 4,
                Nombre = "Team JordiESP",
                FechaNacimiento = DateTime.Now,
                FuerzaCombate = 500,
                Ubicacion = "Ciudad real"
            });

            _ejercitos.Add(new Ejercito()
            {
                Id = 5,
                Nombre = "Por favor Dios",
                FechaNacimiento = DateTime.Now,
                FuerzaCombate = 700,
                Ubicacion = "El cielito lindo"
            });

            return _ejercitos;
        }
    }
}
