using System;
using ArchiectureFundamentals.Cases;
using Microsoft.AspNetCore.Mvc;

namespace ArchiectureFundamentals.Controllers
{
    public class ServiceLocatorController : Controller
    {
        private readonly IServiceProvider _serviceProvider;

        public ServiceLocatorController(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public void Index()
        {
            // If not registered, it return null
            //_serviceProvider.GetRequiredService<IUserServices>.AddUser(new User());
        }
    }
}