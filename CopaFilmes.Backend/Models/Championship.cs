using System.Collections.Generic;
using System.Linq;

namespace CopaFilmes.Backend.Models
{
    public class Championship
    {
        public IEnumerable<Phase> Phases { get; private set; }

        public Championship(params Phase[] phases)
        {
            Phases = phases;
        }

        public IEnumerable<Film> DetermineWinners(IEnumerable<Film> films)
        {
            films = films.OrderBy(film => film.Titulo);
            
            return Phases.Aggregate(films, (accumulator, phase) => phase.DetermineWinners(accumulator));
        }
    }
}