import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FacultyShowComponent } from './faculty-show.component';

describe('FacultyShowComponent', () => {
  let component: FacultyShowComponent;
  let fixture: ComponentFixture<FacultyShowComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [FacultyShowComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FacultyShowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
