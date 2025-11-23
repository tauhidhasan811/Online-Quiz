import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-student-show',
  imports: [HttpClientModule, CommonModule],
  templateUrl: './student-show.component.html',
  styleUrl: './student-show.component.css'
})
export class StudentShowComponent implements OnInit 
{
  students: any;


  constructor(private http: HttpClient){}
  ngOnInit()
  {
    this.http.get("https://localhost:44398/api/student/getall", {withCredentials:true})
    .subscribe(
      (response) =>
      {
        this.students = response;
        console.log(response)
      }
    );
    
  }
  

}
