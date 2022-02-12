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
    public class НапитокController : ApiController
    {
        private MachineDrinksEntities db = new MachineDrinksEntities();

        // GET: api/Напиток
        [ResponseType(typeof(ResponseНапиток))]
        public IHttpActionResult GetНапиток()
        {
            return Ok(db.Напиток.ToList().ConvertAll(p=>new ResponseНапиток(p)).ToList());
        }

        // GET: api/Напиток/5
        [ResponseType(typeof(Напиток))]
        public IHttpActionResult GetНапиток(int id)
        {
            Напиток напиток = db.Напиток.Find(id);
            if (напиток == null)
            {
                return NotFound();
            }

            return Ok(напиток);
        }

        // PUT: api/Напиток/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutНапиток(int id, Напиток напиток)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != напиток.id)
            {
                return BadRequest();
            }

            db.Entry(напиток).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!НапитокExists(id))
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

        // POST: api/Напиток
        [ResponseType(typeof(Напиток))]
        public IHttpActionResult PostНапиток(Напиток напиток)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Напиток.Add(напиток);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = напиток.id }, напиток);
        }

        // DELETE: api/Напиток/5
        [ResponseType(typeof(Напиток))]
        public IHttpActionResult DeleteНапиток(int id)
        {
            Напиток напиток = db.Напиток.Find(id);
            if (напиток == null)
            {
                return NotFound();
            }

            db.Напиток.Remove(напиток);
            db.SaveChanges();

            return Ok(напиток);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool НапитокExists(int id)
        {
            return db.Напиток.Count(e => e.id == id) > 0;
        }
    }
}