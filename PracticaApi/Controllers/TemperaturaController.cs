using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PracticaApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemperaturaController : ControllerBase
    {
        private IServiceTemperatura ServiceTemperatura;
        public TemperaturaController(IServiceTemperatura ServiceTemperatura)
        {
            this.ServiceTemperatura = ServiceTemperatura;
        }
        // GET api/temperatura
        [HttpGet]
        public ActionResult<IEnumerable<Temperatura>> Get()
        {
            return ServiceTemperatura.GetAll();
        }

        // GET api/temperatura/5
        [HttpGet("{id}")]
        public ActionResult<Temperatura> Get(int id)
        {
            return ServiceTemperatura.Get(id);
        }

        // POST api/temperatura
        [HttpPost]
        public void Post([FromBody] Temperatura temperatura)
        {
            ServiceTemperatura.Save(temperatura);
        }

        // PUT api/temperatura/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Temperatura temperatura)
        {
            ServiceTemperatura.Save(temperatura);
        }

        // DELETE api/temperatura/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            ServiceTemperatura.Delete(id);
        }
    }
}
