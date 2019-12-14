using ArchiectureFundamentals.Cases;
using Microsoft.AspNetCore.Mvc;

namespace ArchiectureFundamentals.Controllers
{
    public class GenericControler : Controller
    {
        private readonly IGenericRepository<User> _userRepository;

        public GenericControler(IGenericRepository<User> userRepository)
        {
            _userRepository = userRepository;
        }

        public void Index()
        {
            _userRepository.Add(new User());
        }
    }
}