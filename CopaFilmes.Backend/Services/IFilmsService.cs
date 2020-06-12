using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using CopaFilmes.Backend.Models;

namespace CopaFilmes.Backend.Services
{
    public interface IFilmsService
    {
        Task<IEnumerable<Film>> GetAll();
        IEnumerable<Film> GenerateChampionship(IEnumerable<Film> films);
        IEnumerable<Film> GetWinners();
    }
}