using System;
using ArchiectureFundamentals.Cases;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace ArchiectureFundamentals.Controllers
{
    public class Service2LocatorController : Controller
    {
        public void Index([FromServices] IServiceProvider serviceProvider)
        {
            // If not registered, return null
            serviceProvider.GetRequiredService<IUserServices>().AddUser(new User());
        }
    }
}