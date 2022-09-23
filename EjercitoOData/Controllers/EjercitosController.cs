using EjercitoOData.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EjercitoOData.Controllers
{
    public class EjercitosController : ODataController
    {
        private EjercitoStoreContext _db;

        public EjercitosController(EjercitoStoreContext context) 
        {
            _db = context;
            if (context.Ejercitos.Count() == 0)
            {
                foreach (var b in DataSource.GetEjercitos())
                {
                    context.Ejercitos.Add(b);
                }
                context.SaveChanges();
            }
        }

        [EnableQuery]
        public IActionResult Get()
        {
            return Ok(_db.Ejercitos);
        }

        // Returns a specific book given its key
        [EnableQuery]
        public IActionResult Get(int key)
        {
            return Ok(_db.Ejercitos.FirstOrDefault(c => c.Id == key));
        }

        [EnableQuery]
        public IActionResult Post([FromBody] Ejercito ejercito)
        {
            _db.Ejercitos.Add(ejercito);
            _db.SaveChanges();
            return Created(ejercito);
        }

        [EnableQuery]
        public IActionResult Delete([FromBody] Ejercito ejercito)
        {
            var ejercitoBorrado = _db.Ejercitos.Find(ejercito.Id);
            _db.Ejercitos.Remove(ejercitoBorrado);
            _db.SaveChanges();
            return Ok();
        }

        [EnableQuery]
        public IActionResult Put([FromBody] Ejercito ejercito)
        {
            _db.Ejercitos.Remove(_db.Ejercitos.ElementAt(ejercito.Id - 1));
            _db.Ejercitos.Add(ejercito);
            _db.SaveChanges();
            return Put(ejercito);
        }
    }
}
