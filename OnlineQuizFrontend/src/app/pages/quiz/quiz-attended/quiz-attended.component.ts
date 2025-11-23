import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-quiz-attended',
  imports: [HttpClientModule, CommonModule],
  templateUrl: './quiz-attended.component.html',
  styleUrl: './quiz-attended.component.css'
})
export class QuizAttendedComponent implements OnInit{
  constructor(private http : HttpClient, private route: ActivatedRoute){}

  
  studentQuizes: any;
  ngOnInit(): void{
    let studentid = this.route.snapshot.paramMap.get('studentid');
  this.http.get(`https://localhost:44398/api/studentquiz/getbystudentid/${studentid}`, {withCredentials:true})
  .subscribe(
    (response)=>
    {
      this.studentQuizes = response;
      console.log(this.studentQuizes);
    }
  );
}
}

