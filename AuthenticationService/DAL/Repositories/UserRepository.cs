using AuthenticationService.BLL.Models;

namespace AuthenticationService.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly List<User> _users = new List<User>();
        public UserRepository() 
        {
            _users.Add(new User
            {
                Id = Guid.NewGuid(),
                Login = "mareuou",
                FirstName = "Leonid",
                LastName = "Ivanov",
                Email = "hexhex@gmail.com",
                Password = "password",
                Role = new Role() { 
                    Id = 1,
                    Name ="Пользователь"
                }
            });

            _users.Add(new User
            {
                Id = Guid.NewGuid(),
                Login = "gigizz",
                FirstName = "Valeri",
                LastName = "Gorden",
                Email = "valeriGorde@mail.ru",
                Password = "lera",
                Role = new Role()
                {
                    Id = 1,
                    Name = "Пользователь"
                }
            });

            _users.Add(new User
            {
                Id = Guid.NewGuid(),
                Login = "whyyousoserious",
                FirstName = "Josh",
                LastName = "Black",
                Email = "jblack@gmail.com",
                Password = "joshjosh",
                Role = new Role()
                {
                    Id = 2,
                    Name = "Администратор"
                }
            });

        }
        public IEnumerable<User> GetAll()
        {
            return _users;
        }

        public User GetByLogin(string login)
        {
            return _users.FirstOrDefault(u => u.Login == login);
        }
    }
}
