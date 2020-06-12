import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { WinnerFilmCardComponent } from './winner-film-card.component';

describe('WinnerFilmCardComponent', () => {
  let component: WinnerFilmCardComponent;
  let fixture: ComponentFixture<WinnerFilmCardComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ WinnerFilmCardComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(WinnerFilmCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
