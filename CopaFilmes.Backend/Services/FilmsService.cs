using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using CopaFilmes.Backend.Models;

namespace CopaFilmes.Backend.Services
{
    public class FilmsService : IFilmsService
    {
        private readonly IFilmsRepository _repository;
        private readonly HttpClient _http;

        public FilmsService(IFilmsRepository repository, HttpClient http)
        {
            _repository = repository;
            _http = http;
        }

        public async Task<IEnumerable<Film>> GetAll()
        {
            var response = await _http.GetAsync("/api/filmes");
            using var body = await response.Content.ReadAsStreamAsync();
            
            var films = await JsonSerializer.DeserializeAsync<IEnumerable<Film>>(
                body,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return films.OrderBy(film => film.Titulo);
        }

        public IEnumerable<Film> GenerateChampionship(IEnumerable<Film> films)
        {
            var championship = new Championship(8);
            var winners = championship.DetermineWinners(films);

            return _repository.SaveWinners(winners);
        }

        public IEnumerable<Film> GetWinners()
        {
            return _repository.AllWinners();
        }
    }
}