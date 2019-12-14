using ArchiectureFundamentals.Cases;
using Microsoft.AspNetCore.Mvc;

namespace ArchiectureFundamentals.Controllers
{
    public class FromServicesController : Controller
    {
        public void Index([FromServices] IUserServices userServices)
        {
            userServices.AddUser(new User());
        }        
    }
}