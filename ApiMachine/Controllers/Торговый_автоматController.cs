using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ApiMachine.Entities;

namespace ApiMachine.Controllers
{
    public class Торговый_автоматController : ApiController
    {
        private MachineDrinksEntities db = new MachineDrinksEntities();

        // GET: api/Торговый_автомат
        public IHttpActionResult GetТорговый_автомат()
        {
            return Ok(db.Торговый_автомат.ToList());
        }

        // GET: api/Торговый_автомат/5
        [ResponseType(typeof(Торговый_автомат))]
        public IHttpActionResult GetТорговый_автомат(int id)
        {
            Торговый_автомат торговый_автомат = db.Торговый_автомат.Find(id);
            if (торговый_автомат == null)
            {
                return NotFound();
            }

            return Ok(торговый_автомат);
        }

        // PUT: api/Торговый_автомат/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutТорговый_автомат(int id, Торговый_автомат торговый_автомат)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != торговый_автомат.id)
            {
                return BadRequest();
            }

            db.Entry(торговый_автомат).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Торговый_автоматExists(id))
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

        // POST: api/Торговый_автомат
        [ResponseType(typeof(Торговый_автомат))]
        public IHttpActionResult PostТорговый_автомат(Торговый_автомат торговый_автомат)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Торговый_автомат.Add(торговый_автомат);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = торговый_автомат.id }, торговый_автомат);
        }

        // DELETE: api/Торговый_автомат/5
        [ResponseType(typeof(Торговый_автомат))]
        public IHttpActionResult DeleteТорговый_автомат(int id)
        {
            Торговый_автомат торговый_автомат = db.Торговый_автомат.Find(id);
            if (торговый_автомат == null)
            {
                return NotFound();
            }

            db.Торговый_автомат.Remove(торговый_автомат);
            db.SaveChanges();

            return Ok(торговый_автомат);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Торговый_автоматExists(int id)
        {
            return db.Торговый_автомат.Count(e => e.id == id) > 0;
        }
    }
}