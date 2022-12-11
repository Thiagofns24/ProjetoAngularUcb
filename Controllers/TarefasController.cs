using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mission.API2.Data.Repositories;

namespace Mission.API2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {


        private readonly ITarefaRepository _tarefasRepository;

        public TarefasController(ITarefaRepository tarefaRepository)
        {
            _tarefasRepository = tarefaRepository;

        }

        // GET: api/Tarefas
        [HttpGet]
        public static IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Tarefas/5
        [HttpGet("{id}", Name = "Get")]
        public static string Get(int id)
        {
            return "value";
        }

        // POST: api/Tarefas
        [HttpPost]
        public static void Post([FromBody] string value)
        {
        }

        // PUT: api/Tarefas/5
        [HttpPut("{id}")]
        public static void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Tarefas/5
        [HttpDelete("{id}")]
        public static void Delete(int id)
        {
        }
    }
}
