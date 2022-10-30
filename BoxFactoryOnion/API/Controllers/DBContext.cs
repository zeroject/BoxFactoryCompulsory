using Application.Interface.ICustomer;
using Application.Interface.IDatabase;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DBContext : ControllerBase
    {
        private IDataBaseService _dataBaseService { get; set; }
        public DBContext(IDataBaseService dataBaseService)
        {
            _dataBaseService = dataBaseService;
        }

        [HttpPost]
        public void RecreateDB()
        {
            _dataBaseService.RecreateDB();
        }
    }
}
