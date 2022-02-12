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
    public class МонетаController : ApiController
    {
        private MachineDrinksEntities db = new MachineDrinksEntities();

        // GET: api/Монета
        [ResponseType(typeof(ResponseМонета))]
        public IHttpActionResult GetМонета()
        {
            return Ok(db.Монета.ToList().ConvertAll(p=>new ResponseМонета(p)).ToList());
        }

        // GET: api/Монета/5
        [ResponseType(typeof(Монета))]
        public IHttpActionResult GetМонета(int id)
        {
            Монета монета = db.Монета.Find(id);
            if (монета == null)
            {
                return NotFound();
            }

            return Ok(монета);
        }

        // PUT: api/Монета/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutМонета(int id, Монета монета)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != монета.id)
            {
                return BadRequest();
            }

            db.Entry(монета).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!МонетаExists(id))
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

        // POST: api/Монета
        [ResponseType(typeof(Монета))]
        public IHttpActionResult PostМонета(Монета монета)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Монета.Add(монета);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = монета.id }, монета);
        }

        // DELETE: api/Монета/5
        [ResponseType(typeof(Монета))]
        public IHttpActionResult DeleteМонета(int id)
        {
            Монета монета = db.Монета.Find(id);
            if (монета == null)
            {
                return NotFound();
            }

            db.Монета.Remove(монета);
            db.SaveChanges();

            return Ok(монета);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool МонетаExists(int id)
        {
            return db.Монета.Count(e => e.id == id) > 0;
        }
    }
}