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
using ApiMachine.Models;

namespace ApiMachine.Controllers
{
    public class Монета_в_торговом_автоматеController : ApiController
    {
        private MachineDrinksEntities db = new MachineDrinksEntities();

        // GET: api/Монета_в_торговом_автомате
        [ResponseType(typeof(ResponseCoinsInMachine))]
        public IHttpActionResult GetМонета_в_торговом_автомате()
        {
            return Ok(db.Монета_в_торговом_автомате.ToList().ConvertAll(p=>new ResponseCoinsInMachine(p)).ToList());
        }

        // GET: api/Монета_в_торговом_автомате/5
        [ResponseType(typeof(Монета_в_торговом_автомате))]
        public IHttpActionResult GetМонета_в_торговом_автомате(int id)
        {
            Монета_в_торговом_автомате монета_в_торговом_автомате = db.Монета_в_торговом_автомате.Find(id);
            if (монета_в_торговом_автомате == null)
            {
                return NotFound();
            }

            return Ok(монета_в_торговом_автомате);
        }

        // PUT: api/Монета_в_торговом_автомате/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutМонета_в_торговом_автомате(int id, Монета_в_торговом_автомате монета_в_торговом_автомате)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != монета_в_торговом_автомате.id)
            {
                return BadRequest();
            }

            db.Entry(монета_в_торговом_автомате).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Монета_в_торговом_автоматеExists(id))
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

        // POST: api/Монета_в_торговом_автомате
        [ResponseType(typeof(Монета_в_торговом_автомате))]
        public IHttpActionResult PostМонета_в_торговом_автомате(Монета_в_торговом_автомате монета_в_торговом_автомате)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Монета_в_торговом_автомате.Add(монета_в_торговом_автомате);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = монета_в_торговом_автомате.id }, монета_в_торговом_автомате);
        }

        // DELETE: api/Монета_в_торговом_автомате/5
        [ResponseType(typeof(Монета_в_торговом_автомате))]
        public IHttpActionResult DeleteМонета_в_торговом_автомате(int id)
        {
            Монета_в_торговом_автомате монета_в_торговом_автомате = db.Монета_в_торговом_автомате.Find(id);
            if (монета_в_торговом_автомате == null)
            {
                return NotFound();
            }

            db.Монета_в_торговом_автомате.Remove(монета_в_торговом_автомате);
            db.SaveChanges();

            return Ok(монета_в_торговом_автомате);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Монета_в_торговом_автоматеExists(int id)
        {
            return db.Монета_в_торговом_автомате.Count(e => e.id == id) > 0;
        }
    }
}