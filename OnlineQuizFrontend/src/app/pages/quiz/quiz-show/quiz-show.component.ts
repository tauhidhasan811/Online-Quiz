import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-quiz-show',
  imports: [HttpClientModule, CommonModule, RouterLink],
  templateUrl: './quiz-show.component.html',
  styleUrl: './quiz-show.component.css'
})
export class QuizShowComponent implements OnInit {
  constructor(private http :HttpClient){}

  usertype: any;
  delete_message:any;
  quizes:any;
  ngOnInit(): void {
    let uid = sessionStorage.getItem("userid");
    console.log(uid);
    this.http.get(`https://localhost:44398/api/quiz/getbyfaculty/${uid}`, {withCredentials:true})
    .subscribe(
      (response)=>
      {
        this.quizes = response;
      }
    )
    this.usertype = localStorage.getItem("usertype");
      
  }

  delete(id:any)
  {
    console.log('delete call');
    this.http.delete(`https://localhost:44398/api/quiz/delete/${id}`, {withCredentials:true})
    .subscribe(
      (response)=>
      {
        this.delete_message = response;
      }
    )
  }

}
