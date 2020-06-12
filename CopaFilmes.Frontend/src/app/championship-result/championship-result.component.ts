import { Component, OnInit } from '@angular/core';
import { FilmService } from '../services/film.service';
import { Film } from '../models/Film';

@Component({
  selector: 'app-championship-result',
  templateUrl: './championship-result.component.html',
  styleUrls: ['./championship-result.component.css']
})
export class ChampionshipResultComponent implements OnInit {

  films: Film[];

  constructor(private service: FilmService) { }

  ngOnInit(): void {
    this.service.getWinners().subscribe(films => this.films = films);
  }

}
