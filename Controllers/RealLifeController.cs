using ArchiectureFundamentals.Cases;
using Microsoft.AspNetCore.Mvc;

namespace ArchiectureFundamentals.Controllers
{
    public class RealLifeController : Controller
    {
        private readonly IUserServices _userServices;

        public RealLifeController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        public void Index()
        {
            _userServices.AddUser(new User());
        }
    }
}