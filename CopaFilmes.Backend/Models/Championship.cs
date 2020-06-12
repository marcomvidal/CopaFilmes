using System.Collections.Generic;
using System.Linq;

namespace CopaFilmes.Backend.Models
{
    public class Championship
    {
        public int Contestants { get; private set; }
        public IEnumerable<Phase> Phases { get; private set; }

        public Championship(int contestants)
        {
            Contestants = contestants;

            Phases = new List<Phase>
            {
                new InitialPhase(contestants),
                new EliminatoryPhase(contestants / 2),
                new FinalPhase(contestants / 4)
            };
        }

        public Championship(int contestants, IEnumerable<Phase> phases)
        {
            Contestants = contestants;
            Phases = phases;
        }

        public IEnumerable<Film> DetermineWinners(IEnumerable<Film> films)
        {
            films = films.OrderBy(film => film.Titulo);
            
            return Phases.Aggregate(films, (accumulator, phase) => phase.DetermineWinners(accumulator));
        }
    }
}