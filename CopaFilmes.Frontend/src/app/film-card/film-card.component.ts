import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';
import { Film } from '../models/Film';

@Component({
  selector: 'app-film-card',
  templateUrl: './film-card.component.html',
  styleUrls: ['./film-card.component.css'],
  host: { 'class': 'col-md-3' }
})
export class FilmCardComponent implements OnInit {

  isSelected: boolean;
  
  @Input()
  film: Film;

  @Input()
  filmCount: number;

  @Output()
  select: EventEmitter<Film> = new EventEmitter<Film>();

  constructor() {
    this.isSelected = false;
  }

  ngOnInit(): void {
  }

  onSelectFilm(): void {
    this.isSelected = !this.isSelected;
    this.select.emit(this.film);
  }

  isDisabled(): boolean {
    return this.isSelected == false && this.filmCount > 7;
  }

}
