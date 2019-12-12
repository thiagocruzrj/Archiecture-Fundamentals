using System;

namespace ArchiectureFundamentals.Cases
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime RegisterDate { get; set; }
    }

    public interface IUserRepository
    {
        void AddUser(User user);
    }

    public class UserRepository : IUserRepository
    {
        public void AddUser(User user)
        {
            // Do something
        }
    }

    public interface IUserServices
    {
        void AddUser(User user);
    }

    public class UserServices : IUserServices
    {
        private readonly IUserRepository _userRepository;

        public UserServices(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public void AddUser(User user)
        {
            _userRepository.AddUser(user);
        }
    }
}