using DaoRestaurant.Entite;
using DaoRestaurant.IDao;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestuarantApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemandeController : ControllerBase
    {

        IDaoDemande daoDemande;
        
        public DemandeController(IDaoDemande daoCategorie)
        {
            this.daoDemande = daoCategorie;
           
        }
    }
}
