import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CourseShowComponent } from './course-show.component';

describe('CourseShowComponent', () => {
  let component: CourseShowComponent;
  let fixture: ComponentFixture<CourseShowComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [CourseShowComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CourseShowComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
