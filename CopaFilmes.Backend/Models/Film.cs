using System;

namespace CopaFilmes.Backend.Models
{
    public class Film
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public int Ano { get; set; }
        public double Nota { get; set; }

        public override bool Equals(object otherFilm)
        {
            return otherFilm is Film film &&
                Id == film.Id &&
                Titulo == film.Titulo &&
                Ano == film.Ano &&
                Nota == film.Nota;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Titulo, Ano, Nota);
        }
    }
}