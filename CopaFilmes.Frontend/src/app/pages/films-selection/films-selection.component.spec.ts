import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { FilmsSelectionComponent } from './films-selection.component';

describe('FilmsSelectionComponent', () => {
  let component: FilmsSelectionComponent;
  let fixture: ComponentFixture<FilmsSelectionComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ FilmsSelectionComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(FilmsSelectionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
