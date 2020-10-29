using CykSoft.CORE.Entities;
using CykSoft.CORE.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CykSoft.INFRASTRUCTURE.Rpositories
{
    public class PostRepository : IPostRepository
    {
        public async Task<IEnumerable<Post>> GetPosts()
        {
            var result = Enumerable.Range(1, 10).Select(x =>
                    new Post
                    {
                        PostID = x,
                        Description = $"Prueba {x}",
                        Date = DateTime.Now,
                        Image = $"https://holi.com/{x}",
                        UserID = x * 2
                    }
                );

            await Task.Delay(100);

            return result;
        }
    }
}
