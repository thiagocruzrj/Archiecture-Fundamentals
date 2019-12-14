using System;
using ArchiectureFundamentals.Cases;
using Microsoft.AspNetCore.Mvc;

namespace ArchiectureFundamentals.Controllers
{
    public class MultileClassesController : Controller
    {
        private readonly Func<string, IService> _serviceAccessor;

        public MultileClassesController(Func<string, IService> serviceAccessor)
        {
            _serviceAccessor = serviceAccessor;
        }

        public string Index()
        {
            return _serviceAccessor("A").Return();
            //return _serviceAccessor("B").Return();
            // return _serviceAccessor("C").Return();
        }
    }
}