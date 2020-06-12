import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { HttpClientModule } from '@angular/common/http';
import { ModelsModule } from './models/models.module';
import { ServicesModule } from './services/services.module';

import { AppComponent } from './app.component';
import { FilmsSelectionComponent } from './films-selection/films-selection.component';
import { BannerComponent } from './banner/banner.component';
import { FilmCardComponent } from './film-card/film-card.component';
import { ChampionshipResultComponent } from './championship-result/championship-result.component';
import { WinnerFilmCardComponent } from './winner-film-card/winner-film-card.component';
import { NavigationBarComponent } from './navigation-bar/navigation-bar.component';

@NgModule({
  declarations: [
    AppComponent,
    FilmsSelectionComponent,
    BannerComponent,
    FilmCardComponent,
    ChampionshipResultComponent,
    WinnerFilmCardComponent,
    NavigationBarComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    ModelsModule,
    ServicesModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
