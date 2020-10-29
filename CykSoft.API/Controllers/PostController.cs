using CykSoft.CORE.Interfaces;
using CykSoft.INFRASTRUCTURE.Rpositories;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CykSoft.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository postRepository;

        public PostController(IPostRepository postRepository) => this.postRepository = postRepository;

        [HttpGet]
        public async Task<IActionResult> GetPosts()
        {
            var posts =  await postRepository.GetPosts();
            return Ok(posts);
        }
    }
}