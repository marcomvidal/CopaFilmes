import { Component, OnInit } from '@angular/core';
import { Film } from '../models/Film';
import { FilmService } from '../services/film.service';

@Component({
  selector: 'app-films-selection',
  templateUrl: './films-selection.component.html',
  styleUrls: ['./films-selection.component.css']
})
export class FilmsSelectionComponent implements OnInit {

  availableFilms: Film[];

  constructor(private service: FilmService) { }

  ngOnInit(): void {
    this.service.getAll()
      .subscribe(films => this.availableFilms = films);
  }

}
