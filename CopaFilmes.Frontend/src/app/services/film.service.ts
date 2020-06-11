import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Film } from '../models/Film';
import { Observable } from 'rxjs';
import { take } from 'rxjs/operators';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class FilmService {

  private url: string;

  constructor(private http: HttpClient) {
    this.url = `${environment.backendUrl}/films`;
  }

  getAll(): Observable<Film[]> {
    return this.http.get<Film[]>(this.url).pipe(take(1));
  }
}
