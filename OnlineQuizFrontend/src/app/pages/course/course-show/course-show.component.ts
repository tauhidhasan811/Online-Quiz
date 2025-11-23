import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-course-show',
  imports: [HttpClientModule, CommonModule],
  templateUrl: './course-show.component.html',
  styleUrl: './course-show.component.css'
})
export class CourseShowComponent {
  constructor(private http :HttpClient){}
  courses: any;
  ngOnInit()
  {
    
    this.http.get("https://localhost:44398/api/course/getall")
    .subscribe(
      (response) =>
      {
        this.courses = response;
        this.courses = response;
        console.log('course ' + this.courses)
      }
    );
    
  }

}
