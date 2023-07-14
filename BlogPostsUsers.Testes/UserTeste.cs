
using BlogPostsUsers.Domain.Interfaces;
using BlogPostsUsers.Domain.Model;
using Moq;
using Xunit;

namespace BlogPostsUsers.Testes
{
    public class UserTeste 
    {

        [Fact]
        public void GetUserId()
        {
            var userServiceMoq = new Mock<IUserService>();
            // Arrange
            var user = new User()
            {
                id = 1,
                city = "goiania",
                country = "Brasil",
                date_of_birth = DateTime.Now,
                email = "teste@gmail.com",
                first_name = "Maria",
                gender = "male",
                job = "develop",
                last_name = "silva",
                latitude = 120544955,
                longitude = -132827509,
                phone = "62984652216",
                state = "GOIAS",
                street = "ROSA",
                zipcode = "71829",
                Posts = new Post[] 
                {
                    new Post()
                    {   id = 1,
                        user_id = 1,
                        category = "programming",
                        content_html = "<HTML>",
                        content_text = "TEXT",
                        created_at = DateTime.Now,
                        description = "descrição",
                        photo_url = "https://api.slingacademy.com/public/sample-blog-posts/5.png",
                        title = "teste",
                        updated_at = DateTime.Now
                    }
                }   
            };

            // Act
            userServiceMoq.Setup(x => x.GetUserById(1)).Returns(user);
            var result = userServiceMoq.Object.GetUserById(1);
            // Assert
            Assert.Equal(user,result);

        }
    }
}