using BlogPostsUsers.Domain.Interfaces;
using BlogPostsUsers.Domain.Model;
using BlogPostsUsers.Domain.Model.DTOs;
using BlogPostsUsers.Infrastructure.DBContext;

namespace BlogPostsUsers.Infrastructure.Repository
{
    public class SincronizaRepository : ISincronizaRepository
    {
        private readonly ContextDb _dbContext;

        public SincronizaRepository(ContextDb dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task SaveUser(IList<UserDTO> userDTOs)
        {
            try
            {
                foreach (var item in userDTOs)
                {
                    var user = new User()
                    {
                        city = item.city,
                        country = item.country,
                        date_of_birth = item.date_of_birth,
                        email = item.email,
                        first_name = item.first_name,
                        gender = item.gender,
                        job = item.job,
                        last_name = item.last_name,
                        latitude = item.latitude,
                        longitude = item.longitude,
                        phone = item.phone,
                        state = item.state,
                        street = item.street,
                        zipcode = item.zipcode,
                    };

                    _dbContext.Users.Add(user);
                    await _dbContext.SaveChangesAsync();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        public async Task SavePost(IList<PostDTO> PostDTOs)
        {
            try
            {
                foreach (var item in PostDTOs)
                {
                    var post = new Post()
                    {
                        category = item.category,
                        content_html = item.content_html,
                        content_text = item.content_text,
                        created_at = item.created_at,
                        description = item.description,
                        photo_url = item.photo_url,
                        title = item.title,
                        updated_at = item.updated_at,
                        user_id = item.user_id,
                    };

                    _dbContext.Posts.Add(post);
                    await _dbContext.SaveChangesAsync();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }



        public void SaveStatusUser(StatusUser statusUser)
        {
            try
            {
                var status = new StatusUser()
                {
                    limit = statusUser.limit,
                    message = statusUser.message,
                    offset = statusUser.offset,
                    success = statusUser.success,
                    time = statusUser.time,
                    total_users = statusUser.total_users,
                    users = null
                };
                _dbContext.StatusUsers.Add(status);
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SaveStatusPost(StatusPost statusPost)
        {
            try
            {
                var statusP = new StatusPost()
                {
                    success = statusPost.success,
                    offset = statusPost.offset,
                    limit = statusPost.limit,
                    message = statusPost.message,
                };
                _dbContext.StatusPosts.Add(statusP);
                _dbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public StatusUser GetOffset(int off)
        {
            try
            {
                var offsetUser = _dbContext.StatusUsers.Where(x => x.offset == off).FirstOrDefault();
                return offsetUser;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public StatusPost GetOffsetPost(int offpost)
        {
            try
            {
                var offsetPost = _dbContext.StatusPosts.Where(x => x.offset == offpost).FirstOrDefault();
                return offsetPost;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
