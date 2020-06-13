import { Component, OnInit } from '@angular/core';
import { FilmService } from '../../services/film.service';
import { Film } from '../../models/Film';
import { Link } from '../../components/breadcrumb-bar/Link';
import { ERROR_MESSAGES } from 'src/app/components/danger-alert/error-messages';

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

  errorMessage: string | null;

  constructor(private service: FilmService) { }

  ngOnInit(): void {
    this.service.getWinners().subscribe(
      films => this.films = films,
      () => this.errorMessage = ERROR_MESSAGES.badConnectivity);
  }

}
