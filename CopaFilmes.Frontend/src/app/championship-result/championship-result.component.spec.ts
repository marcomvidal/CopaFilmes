import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ChampionshipResultComponent } from './championship-result.component';

describe('ChampionshipResultComponent', () => {
  let component: ChampionshipResultComponent;
  let fixture: ComponentFixture<ChampionshipResultComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ChampionshipResultComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ChampionshipResultComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
