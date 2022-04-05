using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    //Signifies that this class is of type apicontroller 
    [ApiController]
    [Route("api/[controller]")] //defines how to access this class from client
    //Controllerbase: "base class from MVC controller without view"
    public class BaseApiController : ControllerBase
    {
    }
}
