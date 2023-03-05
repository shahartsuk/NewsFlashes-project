using Microsoft.AspNetCore.Mvc;
using News.Dal;

namespace News.Server.Controllers
{
    [ApiController]
    [Route("api/ConnectionString")]
    public class CheckConnectionString
    {
        [HttpGet("GetConnectionString")]
        
        public JsonResult GetAllCitiesList()
        {
            ConfigDB connectionString = new ConfigDB();
            return new JsonResult(connectionString.GetConfigConnectionString());
        }
    }
}
