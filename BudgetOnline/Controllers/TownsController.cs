using BudgetOnline.Models;
using EmitMapper;
using EmitMapper.MappingConfiguration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Web.Http;
using System.Web.Http.Description;

namespace BudgetOnline.Controllers
{
    public class TownsController : ApiController
    {
        private BudgetEntities db = new BudgetEntities();

        // GET: api/Towns
        public IQueryable<Towns> GetTowns()
        {
           
            return db.Towns;
        }

        // GET: api/Towns/5
        [ResponseType(typeof(Towns))]
        public IHttpActionResult GetTowns(int id)
        {
            Towns towns = db.Towns.Find(id);
            if (towns == null)
            {
                return NotFound();
            }
            DefaultMapConfig config = new DefaultMapConfig();
            config.ConvertUsing((Towns source) =>
              new TownsOut
              {
                  ID = source.ID,
                  Name = source.Name
              });
            var TownsOut = ObjectMapperManager
                .DefaultInstance
                .GetMapper<Towns, TownsOut>(config)
                .Map(towns);

            return Ok(TownsOut);
        }

        // PUT: api/Towns/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutTowns(int id, Towns towns)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != towns.ID)
            {
                return BadRequest();
            }

            db.Entry(towns).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TownsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Towns
        [ResponseType(typeof(Towns))]
        public IHttpActionResult PostTowns(Towns towns)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Towns.Add(towns);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = towns.ID }, towns);
        }

        // DELETE: api/Towns/5
        [ResponseType(typeof(Towns))]
        public IHttpActionResult DeleteTowns(int id)
        {
            Towns towns = db.Towns.Find(id);
            if (towns == null)
            {
                return NotFound();
            }

            db.Towns.Remove(towns);
            db.SaveChanges();

            return Ok(towns);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool TownsExists(int id)
        {
            return db.Towns.Count(e => e.ID == id) > 0;
        }
    }
}