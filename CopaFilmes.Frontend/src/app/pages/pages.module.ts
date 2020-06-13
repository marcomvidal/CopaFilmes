import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ModelsModule } from '../models/models.module';
import { ServicesModule } from '../services/services.module';
import { ComponentsModule } from '../components/components.module';

import { ChampionshipResultComponent } from './championship-result/championship-result.component';
import { FilmsSelectionComponent } from './films-selection/films-selection.component';

@NgModule({
  declarations: [
    ChampionshipResultComponent,
    FilmsSelectionComponent,
  ],
  imports: [
    CommonModule,
    ModelsModule,
    ServicesModule,
    ComponentsModule,
  ]
})
export class PagesModule { }
