import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AppRoutingModule } from '../app-routing.module';

import { BannerComponent } from './banner/banner.component';
import { FilmCardComponent } from './film-card/film-card.component';
import { BreadcrumbBarComponent } from './breadcrumb-bar/breadcrumb-bar.component';
import { WinnerFilmCardComponent } from './winner-film-card/winner-film-card.component';
import { DangerAlertComponent } from './danger-alert/danger-alert.component';

@NgModule({
  declarations: [
    BannerComponent,
    FilmCardComponent,
    BreadcrumbBarComponent,
    WinnerFilmCardComponent,
    DangerAlertComponent,
  ],
  imports: [
    CommonModule,
    AppRoutingModule,
  ],
  exports: [
    BannerComponent,
    DangerAlertComponent,
    FilmCardComponent,
    BreadcrumbBarComponent,
    WinnerFilmCardComponent,
  ]
})
export class ComponentsModule { }
