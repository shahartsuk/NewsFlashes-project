using Microsoft.AspNetCore.Mvc;
using News.Entities;

namespace News.Server.Controllers
{
    [ApiController]
    [Route("api/ConnectionString")]
    public class CheckConnectionString
    {
        [HttpGet("GetConnectionString")]
        
        public JsonResult CheckRequest()
        {
            return new JsonResult(MainManager.Instance.requestGet.XMLRequestGet());
        }
    }
}
