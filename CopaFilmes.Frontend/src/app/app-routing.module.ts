import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { FilmsSelectionComponent } from './films-selection/films-selection.component';
import { ChampionshipResultComponent } from './championship-result/championship-result.component';


const routes: Routes = [
  { path: 'selecao-de-filmes',  component: FilmsSelectionComponent },
  { path: 'resultado',          component: ChampionshipResultComponent },
  { path: '', redirectTo: '/selecao-de-filmes', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
