using First.App.Domain.Entities;
using System.Collections.Generic;

namespace First.App.Business.Abstract
{
    public interface IPostService
    {
        void AddPost(Post post);
        void AddPosts(List<Post> posts);
    }
}
