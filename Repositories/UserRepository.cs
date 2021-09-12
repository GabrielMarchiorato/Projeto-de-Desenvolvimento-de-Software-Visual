using proj_semestre_backend.Models;
using proj_semestre_backend.Database;
using System.Threading.Tasks;
using System.Linq;


namespace proj_semestre_backend.Repositories
{
    public class UserRepository: IUserRepository
    {
        private ApiContext _context;
        public UserRepository(ApiContext context){
            _context = context;
        }
        public User Get(AuthCredentialsDTO userCredentials) => _context.Users.Where(user => user.Username == userCredentials.username).FirstOrDefault();
        
        public async ValueTask<User> AddUser(User user) {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
            return user;
        }
        
    }
}