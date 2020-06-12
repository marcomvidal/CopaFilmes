import { Component, OnInit, Input } from '@angular/core';
import { Film } from '../models/Film';

@Component({
  selector: 'app-winner-film-card',
  templateUrl: './winner-film-card.component.html',
  styleUrls: ['./winner-film-card.component.css'],
  host: { 'class': 'col-md-3' }
})
export class WinnerFilmCardComponent implements OnInit {

  @Input()
  placement: number;

  @Input()
  film: Film;

  constructor() { }

  ngOnInit(): void {
  }

}
