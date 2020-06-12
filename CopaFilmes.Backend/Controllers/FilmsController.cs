using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CopaFilmes.Backend.Models;
using CopaFilmes.Backend.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CopaFilmes.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilmsController : ControllerBase
    {
        private readonly IFilmsService _service;

        public FilmsController(IFilmsService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.GetAll());
        }

        [HttpPost("generate-championship")]
        public IActionResult GenerateChampionship([FromBody] IEnumerable<Film> films)
        {
            return CreatedAtAction(nameof(Winners), _service.GenerateChampionship(films));
        }

        [HttpGet("winners")]
        public IActionResult Winners()
        {
            return Ok(_service.GetWinners());
        }
    }
}
