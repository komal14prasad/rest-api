using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace CmdApi.Controller
{
    [Route("api/[Controller]")]
    [ApiController]
    public class CommandsController : ControllerBase
    {
        [HttpGet]
        public ActionsResult<IEnumerable<string>> GetAction(){
            return new string[]{"test","first"};
        }
    }
}
