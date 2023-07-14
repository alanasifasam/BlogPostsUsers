using BlogPostsUsers.Domain.Interfaces;
using BlogPostsUsers.Domain.Model;
using BlogPostsUsers.Domain.Model.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;

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

        public  User GetUserById(int id)
        {
            try
            {
                if (id == null) return null;

                return _userRepository.GetUserById(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
