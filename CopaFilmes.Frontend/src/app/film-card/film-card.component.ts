import { Component, OnInit, Input } from '@angular/core';
import { Film } from '../models/Film';

@Component({
  selector: 'app-film-card',
  templateUrl: './film-card.component.html',
  styleUrls: ['./film-card.component.css'],
  host: { 'class': 'col-md-3' }
})
export class FilmCardComponent implements OnInit {

  @Input()
  film: Film;

  constructor() { }

  ngOnInit(): void {
  }

}
