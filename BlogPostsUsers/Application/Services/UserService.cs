using BlogPostsUsers.Domain.Interfaces;
using BlogPostsUsers.Domain.Model;
using BlogPostsUsers.Domain.Model.DTOs;

namespace BlogPostsUsers.Application.Services
{
    public class UserService : IUserService
    {
		private readonly IUserRepository _userRepository;

		public UserService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
        }



        public async Task<IEnumerable<User>> GetAllUsers()
        {
			try
			{
                return await _userRepository.GetAllUsers();
			}
			catch (Exception)
			{

				throw;
			}
        }

        public async Task<User> GetUserById(int id)
        {
            try
            {
                return await _userRepository.GetUserById(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
