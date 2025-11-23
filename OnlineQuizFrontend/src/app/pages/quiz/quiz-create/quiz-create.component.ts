import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { Router } from '@angular/router';

class Quiz{
    Title!: string;
    TotalMark!: number;
    Date!: string;
    Duration!: number;
    StartTime!: string;
    //EndTime!: string;
    CourseId!:number;
    FacultyId!: number;
}
@Component({
  selector: 'app-quiz-create',
  imports: [HttpClientModule, ReactiveFormsModule, CommonModule],
  templateUrl: './quiz-create.component.html',
  styleUrl: './quiz-create.component.css'
})
export class QuizCreateComponent implements OnInit
{
   facultyId: any;
  constructor(private http:HttpClient, private route: Router){}
  courses: any;
  ngOnInit(): void {
      this.http.get("https://localhost:44398/api/course/getall", {withCredentials:true})
    .subscribe(
      (response) =>
      {
        this.courses = response;
        console.log(response)
      }
    );
  }
  QuizData = new FormGroup({
    Title: new FormControl(''),
    TotalMark: new FormControl(''),
    Date: new FormControl(''),
    //Counts: new FormControl(''),
    Duration: new FormControl(''),
    StartTime: new FormControl(''),
    //EndTime: new FormControl(''),
    CourseId: new FormControl('')
  });

  quizid: any;
 
  OnSubmit()
  {
    this.facultyId = sessionStorage.getItem('userid')
    console.log(this.facultyId);
    const data = {
      ...this.QuizData.value,
      FacultyId: this.facultyId
    }
    console.log(data)
    this.http.post("https://localhost:44398/api/quiz/create", data, {withCredentials:true, observe:'response'})
    .subscribe(
      (res: any) =>
      {
        this.quizid = res.body?.quizid;
        this.route.navigate(['/question-create', this.quizid]);
        console.log(res);
      }
    )
  }
 
}
