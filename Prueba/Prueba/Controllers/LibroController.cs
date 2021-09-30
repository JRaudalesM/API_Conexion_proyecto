using Microsoft.AspNetCore.Mvc;
using Prueba.Contexts;
using Prueba.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Prueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase

    {
        private readonly DBContxt context;

        public LibroController(DBContxt context)
        {
            this.context = context;
        }
        // GET: api/<LibroController>
        [HttpGet]
        public IEnumerable<Libro> Get()
        {
            return context.Libro.ToList();
        }

        // GET api/<LibroController>/5
        [HttpGet("{id}")]
        public Libro Get(int id)
        {
            var Libro = context.Libro.FirstOrDefault(p=>p.Idlibro==id);
            return Libro;
        }

        // POST api/<LibroController>
        [HttpPost]
        public ActionResult Post([FromBody] Libro libro)
        {
            try {
                context.Libro.Add(libro);
                context.SaveChanges();
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
            
        }

        // PUT api/<LibroController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Libro libro)
        {

            if (libro.Idlibro == id)
            {
                context.Entry(libro).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                return Ok();
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE api/<LibroController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var libro = context.Libro.FirstOrDefault(p=>p.Idlibro == id);
            if(libro != null) {
                context.Libro.Remove(libro);
                context.SaveChanges();
                return Ok();

            }
            else
            {
                return BadRequest();
            }
        }
    }
}
