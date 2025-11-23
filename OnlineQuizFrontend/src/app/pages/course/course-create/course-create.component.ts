import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-course-create',
  imports: [HttpClientModule, ReactiveFormsModule],
  templateUrl: './course-create.component.html',
  styleUrl: './course-create.component.css'
})
export class CourseCreateComponent 
{
  constructor(private http : HttpClient){}
  coursedata = new FormGroup(
    {
      Name :new FormControl(""),
      CourseCode: new FormControl("")
    });

    onSubmit()
    {
      this.http.post("https://localhost:44398/api/course/create", this.coursedata.value)
      .subscribe(
        (response) =>{
          console.log(response)
        }
      )
    }
}
