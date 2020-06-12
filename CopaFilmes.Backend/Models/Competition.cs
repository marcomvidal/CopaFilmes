namespace CopaFilmes.Backend.Models
{
    public class Competition
    {
        public Film FirstCompetitor { get; private set; }
        public Film SecondCompetitor { get; private set; }

        public Competition(Film firstCompetitor, Film secondCompetitor)
        {
            FirstCompetitor = firstCompetitor;
            SecondCompetitor = secondCompetitor;
        }

        public Film DetermineWinner()
        {
            if (FirstCompetitor.Nota == SecondCompetitor.Nota)
            {
                bool isTheNameOfTheFirstFilmEarlier = 
                    string.Compare(FirstCompetitor.Titulo, SecondCompetitor.Titulo) == -1 ||
                    string.Compare(FirstCompetitor.Titulo, SecondCompetitor.Titulo) == 0;

                return isTheNameOfTheFirstFilmEarlier ? FirstCompetitor : SecondCompetitor;
            }
            
            return FirstCompetitor.Nota > SecondCompetitor.Nota ? FirstCompetitor : SecondCompetitor;
        }
    }
}