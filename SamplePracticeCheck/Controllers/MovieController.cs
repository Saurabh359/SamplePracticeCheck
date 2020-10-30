using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace SamplePracticeCheck.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {
        private static readonly List<Movie> movies = new List<Movie>()
        {
            new Movie{ Id=1,Title="Avengers",Category="Action",Director="Joe Russo", ReleaseDate=Convert.ToDateTime("2019-11-24 07:12:00 PM")},
            new Movie{ Id=2,Title="Abcd",Category="Dance",Director="PrabhuDeva", ReleaseDate=Convert.ToDateTime("2017-12-14 05:12:00 PM")},
            new Movie{ Id=3,Title="Avtar",Category="Action",Director="Joe Russo", ReleaseDate=Convert.ToDateTime("2005-11-19 03:12:00 PM")},
            new Movie{ Id=4,Title="IronMan",Category="Action",Director="Joe Russo", ReleaseDate=Convert.ToDateTime("2007-05-21 05:12:00 PM")},
            new Movie{ Id=5,Title="Batman",Category="Action",Director="Joe Russo", ReleaseDate=Convert.ToDateTime("2018-11-24 06:12:00 PM")}
        };

        private readonly ILogger<MovieController> _logger;

        public MovieController(ILogger<MovieController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public List<Movie> Get()
        {
            return movies;
        }
    }
}
