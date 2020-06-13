using System.Collections.Generic;
using CopaFilmes.Backend.Models;

namespace CopaFilmes.Backend.Repositories
{
    public interface IFilmsRepository
    {
        IEnumerable<Film> AllWinners();
        IEnumerable<Film> SaveWinners(IEnumerable<Film> films);
    }
}