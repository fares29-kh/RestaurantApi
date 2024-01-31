using DaoRestaurant.Dao;
using DaoRestaurant.Entite;
using DaoRestaurant.IDao;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestuarantApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        IDaoClient daoClient;
        Client _client;
        public ClientController(IDaoClient daoClient)
        {
            this.daoClient = daoClient;
            _client = new Client();
        }

        // GET: api/Parkings
        [HttpGet]
        public async Task<ActionResult<List<Client>>> GetClients()
        {

            return daoClient.GetClients();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Client>> GetClinet(int id)
        {

            _client = daoClient.GetClient(id);

            if (_client == null)
            {
                return NotFound();
            }

            return _client;
        }


        [HttpPost]
        public async Task<ActionResult<Client>> PostClient(Client clt)
        {
            daoClient.InsertClient(clt);


            return CreatedAtAction("GetClient", new { id = _client.id_client }, _client);
        }

       
       


    }



}
