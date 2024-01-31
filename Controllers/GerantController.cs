using DaoRestaurant.IDao;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestuarantApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GerantController : ControllerBase
    {
        IDaoGerant daoGerant;

        public GerantController(IDaoGerant daoGerant)
        {
            this.daoGerant = daoGerant;

        }
    }
}
