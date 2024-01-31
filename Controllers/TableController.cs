using DaoRestaurant.Dao;
using DaoRestaurant.Entite;
using DaoRestaurant.IDao;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestuarantApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableController : ControllerBase
    {
        IDaoTable daoTable;
        Table _table;

        public TableController(IDaoTable daoTable)
        {

            this.daoTable = daoTable;
            _table = new Table();

        }
        [HttpGet]
        public async Task<ActionResult<List<Table>>> GetTables()
        {

            return daoTable.GetTables();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Table>> GetTable(int id)
        {

            _table = daoTable.GetTable(id);

            if (_table == null)
            {
                return NotFound();
            }

            return _table;
        }


        [HttpPost]
        public async Task<ActionResult<Table>> PostTable(Table clt)
        {
            daoTable.InsertTable(clt);


            return CreatedAtAction("GetTable", new { id = _table.num_table }, _table);
        }


        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTable(int id)
        {

            var _table = daoTable.GetTable(id);
            if (_table == null)
            {
                return NotFound();
            }
            else

                daoTable.DeleteTable(id);

            return NoContent();
        }
        
       
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTable(Table table)
        {

            var _table = daoTable.GetTable(table.num_table);
            if (_table == null)
            {
                return NotFound();
            }
            else

                daoTable.UpdateTable(table);

            return NoContent();
        }

        public interface IActionResult<T>
        {
        }
    }
}
