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
    public class Напиток_из_торгового_автоматаController : ApiController
    {
        private MachineDrinksEntities db = new MachineDrinksEntities();

        // GET: api/Напиток_из_торгового_автомата
        [ResponseType(typeof(ResponseDrinksInMachine))]
        public IHttpActionResult GetНапиток_из_торгового_автомата()
        {
            return Ok(db.Напиток_из_торгового_автомата.ToList().ConvertAll(p => new ResponseDrinksInMachine(p)).ToList());
        }

        // GET: api/Напиток_из_торгового_автомата/5
        [ResponseType(typeof(Напиток_из_торгового_автомата))]
        public IHttpActionResult GetНапиток_из_торгового_автомата(int id)
        {
            Напиток_из_торгового_автомата напиток_из_торгового_автомата = db.Напиток_из_торгового_автомата.Find(id);
            if (напиток_из_торгового_автомата == null)
            {
                return NotFound();
            }

            return Ok(напиток_из_торгового_автомата);
        }

        // PUT: api/Напиток_из_торгового_автомата/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutНапиток_из_торгового_автомата(int id, Напиток_из_торгового_автомата напиток_из_торгового_автомата)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != напиток_из_торгового_автомата.id)
            {
                return BadRequest();
            }

            db.Entry(напиток_из_торгового_автомата).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Напиток_из_торгового_автоматаExists(id))
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

        // POST: api/Напиток_из_торгового_автомата
        [ResponseType(typeof(Напиток_из_торгового_автомата))]
        public IHttpActionResult PostНапиток_из_торгового_автомата(Напиток_из_торгового_автомата напиток_из_торгового_автомата)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Напиток_из_торгового_автомата.Add(напиток_из_торгового_автомата);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = напиток_из_торгового_автомата.id }, напиток_из_торгового_автомата);
        }

        // DELETE: api/Напиток_из_торгового_автомата/5
        [ResponseType(typeof(Напиток_из_торгового_автомата))]
        public IHttpActionResult DeleteНапиток_из_торгового_автомата(int id)
        {
            Напиток_из_торгового_автомата напиток_из_торгового_автомата = db.Напиток_из_торгового_автомата.Find(id);
            if (напиток_из_торгового_автомата == null)
            {
                return NotFound();
            }

            Напиток напиток = db.Напиток.FirstOrDefault(c => c.id == напиток_из_торгового_автомата.Id_напиток);
            db.Напиток.Remove(напиток);
            db.SaveChanges();   
            db.Напиток_из_торгового_автомата.Remove(напиток_из_торгового_автомата);
            db.SaveChanges();

            return Ok(напиток_из_торгового_автомата);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Напиток_из_торгового_автоматаExists(int id)
        {
            return db.Напиток_из_торгового_автомата.Count(e => e.id == id) > 0;
        }
    }
}