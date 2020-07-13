using Microsoft.AspNetCore.Mvc;

namespace AluraPic.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UploadController : Controller
    {
        [HttpPost, DisableRequestSizeLimit]
        public IActionResult Upload(Photo photo)
        {
            return Ok();
        }
    }
}