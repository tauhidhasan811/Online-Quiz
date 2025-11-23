import { ComponentFixture, TestBed } from '@angular/core/testing';

import { QuizShowStudentComponent } from './quiz-show-student.component';

describe('QuizShowStudentComponent', () => {
  let component: QuizShowStudentComponent;
  let fixture: ComponentFixture<QuizShowStudentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [QuizShowStudentComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(QuizShowStudentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
