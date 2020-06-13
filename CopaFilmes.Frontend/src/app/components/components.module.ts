import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AppRoutingModule } from '../app-routing.module';
import { BannerComponent } from './banner/banner.component';
import { FilmCardComponent } from './film-card/film-card.component';
import { BreadcrumbBarComponent } from './breadcrumb-bar/breadcrumb-bar.component';
import { WinnerFilmCardComponent } from './winner-film-card/winner-film-card.component';

@NgModule({
  declarations: [
    BannerComponent,
    FilmCardComponent,
    BreadcrumbBarComponent,
    WinnerFilmCardComponent,
  ],
  imports: [
    CommonModule,
    AppRoutingModule,
  ],
  exports: [
    BannerComponent,
    FilmCardComponent,
    BreadcrumbBarComponent,
    WinnerFilmCardComponent,
  ]
})
export class ComponentsModule { }
