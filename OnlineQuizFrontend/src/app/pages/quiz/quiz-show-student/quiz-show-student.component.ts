import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-quiz-show-student',
  imports: [CommonModule, HttpClientModule, RouterLink],
  templateUrl: './quiz-show-student.component.html',
  styleUrl: './quiz-show-student.component.css'
})
export class QuizShowStudentComponent implements OnInit {
  constructor(private http :HttpClient){}

  usertype: any;

  quizes:any;
  ngOnInit(): void {
    let uid = sessionStorage.getItem("userid");
    console.log(uid);
    this.http.get(`https://localhost:44398/api/quiz/getall`, {withCredentials:true})
    .subscribe(
      (response)=>
      {
        this.quizes = response;
      }
    )
    this.usertype = localStorage.getItem("usertype");
      
  }
}
