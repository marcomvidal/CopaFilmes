import { Component, OnInit } from '@angular/core';
import { FilmService } from '../../services/film.service';
import { Film } from '../../models/Film';
import { Link } from '../../components/breadcrumb-bar/Link';

@Component({
  selector: 'app-championship-result',
  templateUrl: './championship-result.component.html',
  styleUrls: ['./championship-result.component.css']
})
export class ChampionshipResultComponent implements OnInit {

  films: Film[];
  breadcrumbLinks: Link[] = [
    new Link('Seleção de filmes', '/selecao-de-filmes', false),
    new Link('Resultado final', '/resultado', true)
  ];

  constructor(private service: FilmService) { }

  ngOnInit(): void {
    this.service.getWinners().subscribe(films => this.films = films);
  }

}
