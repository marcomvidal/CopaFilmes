using System;
using System.Collections.Generic;
using CopaFilmes.Backend.Models;
using Microsoft.Extensions.Caching.Memory;

namespace CopaFilmes.Backend.Repositories
{
    public class FilmsRepository : IFilmsRepository
    {
        private readonly IMemoryCache _memoryCache;
        private const string _cacheKey = "WinnerFilms";

        public FilmsRepository(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }

        public IEnumerable<Film> AllWinners()
        {
            List<Film> winners;
            _memoryCache.TryGetValue(_cacheKey, out winners);

            return winners;
        }

        public IEnumerable<Film> SaveWinners(IEnumerable<Film> winners)
        {
            var options = new MemoryCacheEntryOptions { AbsoluteExpiration = DateTime.Now.AddHours(1) };
            _memoryCache.Set(_cacheKey, winners, options);

            return winners;
        }
    }
}