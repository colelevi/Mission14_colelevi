using Microsoft.AspNetCore.Mvc;
using Mission14_API.Data;
using System.Linq;

namespace Mission14_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : Controller
    {
        private MovieDbContext context;

        public MovieController (MovieDbContext temp)
        {
            context = temp;
        }
        
        public IEnumerable<MovieCollection> Get()
        {
            return (context.Movies.ToArray()
                .Where(x => x.Edited == "Yes")
                .OrderBy(x => x.Title));
        }

    }
}
