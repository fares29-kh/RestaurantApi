using DaoRestaurant.Entite;
using DaoRestaurant.IDao;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestuarantApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategorieController : ControllerBase
    {

        IDaoCategorie daoCategorie;
        Categorie _categorie;
        public CategorieController(IDaoCategorie daoCategorie)
        {
            this.daoCategorie = daoCategorie;
            _categorie = new Categorie();
        }
        // GET: api/Parkings
        [HttpGet]
        public async Task<ActionResult<List<Categorie>>> GetCategories()
        {

            return daoCategorie.GetCategories();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Categorie>> GetCategorie(int id)
        {

            _categorie = daoCategorie.GetCategorie(id);

            if (_categorie == null)
            {
                return NotFound();
            }

            return _categorie;
        }


        [HttpPost]
        public async Task<ActionResult<Categorie>> PostCategorie(Categorie clt)
        {
            daoCategorie.InsertCategorie(clt);


            return CreatedAtAction("GetCategorie", new { id = _categorie.id_categorie }, _categorie);
        }


        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategorie(int id)
        {

            var _categorie = daoCategorie.GetCategorie(id);
            if (_categorie == null)
            {
                return NotFound();
            }
            else

                daoCategorie.DeleteCategorie(id);

            return NoContent();
        }
        // UPDATE: api/Products/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategorie(Categorie categorie)
        {

            var _categorie = daoCategorie.GetCategorie(categorie.id_categorie);
            if (_categorie == null)
            {
                return NotFound();
            }
            else

                daoCategorie.UpdateCategorie(categorie);

            return NoContent();
        }
    }
}
