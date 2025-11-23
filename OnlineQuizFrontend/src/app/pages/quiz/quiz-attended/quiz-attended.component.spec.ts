import { ComponentFixture, TestBed } from '@angular/core/testing';

import { QuizAttendedComponent } from './quiz-attended.component';

describe('QuizAttendedComponent', () => {
  let component: QuizAttendedComponent;
  let fixture: ComponentFixture<QuizAttendedComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [QuizAttendedComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(QuizAttendedComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
