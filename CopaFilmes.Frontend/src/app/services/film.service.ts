import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Film } from '../models/Film';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class FilmService {

  constructor(private http: HttpClient) { }

  getAll(): Observable<Film[]> {
    return this.http.get<Film[]>('https://localhost:5001/api/films');
  }
}
