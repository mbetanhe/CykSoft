using CykSoft.CORE.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CykSoft.CORE.Interfaces
{
    public interface IPostRepository
    {
        Task<IEnumerable<Post>> GetPosts();
    }
}
