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
    public class UsuariosController : ControllerBase
    {

        private readonly DBContxt context;
        public UsuariosController(DBContxt context) {
            this.context = context;
        }

        // GET: api/<Usuarios>
        [HttpGet]
        public IEnumerable<Usuarios> Get()
        {
            return context.Usuarios.ToList();
        }

        // GET api/<Usuarios>/5
        [HttpGet("{id}")]
        public Usuarios Get(int id)
        {
            var Usuarios = context.Usuarios.FirstOrDefault(p => p.Id == id);
            return Usuarios;
        }

        // POST api/<Usuarios>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<Usuarios>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<Usuarios>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
