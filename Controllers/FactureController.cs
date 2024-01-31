using DaoRestaurant.IDao;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestuarantApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactureController : ControllerBase
    {
        IDaoFacture daoDemande;

        public FactureController(IDaoFacture daoFacture)
        {
            this.daoDemande = daoFacture;

        }
    }
}
