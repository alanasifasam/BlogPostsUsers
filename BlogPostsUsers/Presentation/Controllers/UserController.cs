using BlogPostsUsers.Domain.Interfaces;
using BlogPostsUsers.Domain.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BlogPostsUsers.Presentation.Controllers
{
    [ApiController]
    [Route(template: "v1")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route(template: "api/User/GetAllAsync")]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                var users = await _userService.GetAllUsers();

                return users == null ? NotFound() : Ok(users);
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }

        }

        [HttpGet]
        [Route(template: "api/User/GetUserPosts")]
        public IActionResult GetUserPosts(int id)
        {
            try
            {
                
                var user =  _userService.GetUserById(id);

                var response = new { User = user };
                
                return user == null ? NotFound() : Ok(response);
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }
    }
}
