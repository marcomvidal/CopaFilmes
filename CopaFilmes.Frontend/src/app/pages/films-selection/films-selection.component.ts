import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Film } from '../../models/Film';
import { FilmService } from '../../services/film.service';
import { Link } from '../../components/breadcrumb-bar/Link';

@Component({
  selector: 'app-films-selection',
  templateUrl: './films-selection.component.html',
  styleUrls: ['./films-selection.component.css']
})
export class FilmsSelectionComponent implements OnInit {

  availableFilms: Film[];
  selectedFilms: Film[];
  breadcrumbLinks: Link[] = [
    new Link('Seleção de filmes', '/selecao-de-filmes', true)
  ];

  constructor(
    private router: Router,
    private service: FilmService) {
    this.selectedFilms = [];
  }

  ngOnInit(): void {
    this.service.getAll().subscribe(films => this.availableFilms = films);
  }

  isGenerateButtonDisabled(): boolean {
    return this.selectedFilms.length != 8;
  }

  onSelectFilm($event: Film): void {
    this.selectedFilms = this.selectedFilms.includes($event) ?
      this.selectedFilms.filter(film => film != $event) :
      this.selectedFilms.concat($event);
  }

  onGenerateChampionship(): void {
    this.service.generateChampionship(this.selectedFilms)
      .subscribe(() => this.router.navigate(['/resultado']));
  }
}
