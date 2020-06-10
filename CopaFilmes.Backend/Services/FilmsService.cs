using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using CopaFilmes.Backend.Models;

namespace CopaFilmes.Backend.Services
{
    public class FilmsService : IFilmsService
    {
        private readonly HttpClient _http;

        public FilmsService(HttpClient http)
        {
            _http = http;
        }

        public async Task<IEnumerable<Film>> GetAll()
        {
            var response = await _http.GetAsync("/api/filmes");
            using var body = await response.Content.ReadAsStreamAsync();
            
            var films = await JsonSerializer.DeserializeAsync<IEnumerable<Film>>(
                body,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return films.OrderBy(f => f.Titulo);
        }
    }
}