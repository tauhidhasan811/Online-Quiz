import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component,OnInit } from '@angular/core';
import { ActivatedRoute, Route, Router } from '@angular/router';
import {CommonModule, DatePipe} from '@angular/common';
import { QuestionShowComponent } from '../../question/question-show/question-show.component';

@Component({
  selector: 'app-quiz-details',
  imports: [HttpClientModule, CommonModule, QuestionShowComponent],
  providers: [DatePipe],
  templateUrl: './quiz-details.component.html',
  styleUrl: './quiz-details.component.css'
})
export class QuizDetailsComponent implements OnInit {
  constructor(private http: HttpClient, 
    private route: ActivatedRoute, 
    private datePipe: DatePipe,
    private router: Router){}
  quiz: any;
  quizid: any;
   squizid :any;
  usertype: any = sessionStorage.getItem("usertype");
  ngOnInit(): void {
    this.usertype = sessionStorage.getItem("usertype");
    console.log("User Type is : ",this.usertype)
    this.quizid = this.route.snapshot.paramMap.get('id');
    
    this.http.get(`https://localhost:44398/api/quiz/details/${this.quizid}`, {withCredentials: true})
    .subscribe(
      (response) =>
      {
        this.quiz = response;
        console.log(response);
      }
    );
  
  }

  startQuiz(){
    let QuizId = this.quizid;
   
    let StudentId = sessionStorage.getItem('userid');
    this.http.post('https://localhost:44398/api/studentquiz/create', {QuizId, StudentId}, {withCredentials: true})
    .subscribe(
      (response) => {
        this.squizid = response;
        console.log('Quiz started successfully', response);
        sessionStorage.setItem('quizid', this.squizid);
        this.router.navigate([`/question-show/${this.quizid}`]);
      },
      (error) => {
        console.error('Error starting quiz', error);
        alert('Error starting quiz. Please try again.');
      }
    );
  }

}
