using DaoRestaurant.IDao;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestuarantApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServeurController : ControllerBase
    {
        IDaoServeur daoServeur;

        public ServeurController(IDaoServeur daoServeur)
        {
            this.daoServeur = daoServeur;

        }
    }
}
