import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { FilmsSelectionComponent } from './films-selection/films-selection.component';


const routes: Routes = [
  { path: 'films-selection', component: FilmsSelectionComponent },
  { path: '', redirectTo: '/films-selection', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
