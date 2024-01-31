using DaoRestaurant.Entite;
using DaoRestaurant.IDao;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestuarantApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : ControllerBase
    {
        IDaoService daoService;
        Service _service;

        public ServiceController(IDaoService daoService)
        {
         
            this.daoService = daoService;
            _service = new Service();

        }
        // GET: api/Parkings
        [HttpGet]
        public async Task<ActionResult<List<Service>>> GetServices()
        {

            return daoService.GetServices();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Service>> GetService(int id)
        {

            _service = daoService.GetService(id);

            if (_service == null)
            {
                return NotFound();
            }

            return _service;
        }


        [HttpPost]
        public async Task<ActionResult<Service>> PostService(Service clt)
        {
            daoService.InsertService(clt);


            return CreatedAtAction("GetService", new { id = _service.id_service}, _service);
        }


        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteService(int id)
        {

            var _service = daoService.GetService(id);
            if (_service == null)
            {
                return NotFound();
            }
            else

                daoService.DeleteService(id);

            return NoContent();
        }
        // UPDATE: api/Products/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateService(Service service)
        {

            var _service = daoService.GetService(service.id_service);
            if (_service == null)
            {
                return NotFound();
            }
            else

                daoService.UpdateService(service);

            return NoContent();
        }
    }
}
