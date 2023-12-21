using Microsoft.AspNetCore.Mvc;
using TakinginfofromHtttpIpinAcelot.Httpclinet;

namespace TakinginfofromHtttpIpinAcelot.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class GetIdentityserviceController : ControllerBase
    {
        private readonly ClientService _ClientService;

        public GetIdentityserviceController(ClientService clientService)
        {
            _ClientService = clientService;
        }
        [HttpGet]
        public async Task<string> Identityintegration()
        {
            //HttpRequestMessage reqmessage = new HttpRequestMessage(HttpMethod.Post, "http://10.10.2.143:7016/api/Authentication/login");
          var tokens=await _ClientService.SendRequestAsync(new(), "Alisher", "Alisher@123", "http://10.10.2.143:7016/api/Authentication/login");
            return tokens;
        }
    }
}
