/*import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';
import {ActivatedRoute } from '@angular/router'; 
export class Question {
  Title!: string;
  QuestionType!: string;
  QuizId!: number;
  constructor(data?: Partial<Question>) {
    if (data) {
      this.Title = data.Title || '';
      this.QuestionType = data.QuestionType || '';
      this.QuizId = data.QuizId || 0;
    }
  }
}
@Component({
  selector: 'app-question-create',
  imports: [CommonModule, ReactiveFormsModule, HttpClientModule],
  templateUrl: './question-create.component.html',
  styleUrl: './question-create.component.css'
})
export class QuestionCreateComponent implements OnInit
{
  questionid: any;
  quiztype: string[] = [];
  ngOnInit(): void {
    this.quiztype= ['MCQ', 'True/False', 'Fill in the Blanks'];
  }
  

  quizid: any;
 QuestionData = new FormGroup(
    {
      Title: new FormControl(''),
      QuestionType: new FormControl('')
    }
  )
  options = new FormGroup(
    {
      Text: new FormControl(''),
      IsCorrect: new FormControl(false)
    }
  );
  questions: Question []=[];
  constructor(private http: HttpClient, private route: ActivatedRoute) {
    console.log(this.route.snapshot.paramMap.get('id'));
    this.quizid = this.route.snapshot.paramMap.get('id');
    console.log(this.questions)
  }
  addquestion()
  {
    const newQuestion = new Question(this.QuestionData.value as Question);
    newQuestion.QuizId = this.quizid;
    this.questions.push(newQuestion);

    this.QuestionData.reset();

    console.log(this.questions); 

  }
  addoption()
{
  console.log(this.options.value);
  this.http.post("https://localhost:44398/api/option/create", this.options.value, {withCredentials: true})
  .subscribe(
    response => 
    {
      console.log(response)
    }
  )
}
  submit()
  {
    this.http.post("https://localhost:44398/api/question/create", this.questions, {withCredentials: true})
    .subscribe(
      response => 
      {
        this.questionid = response;
        console.log(response)
      }
    )
  }
}
  */


/*
import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';
import {ActivatedRoute } from '@angular/router'; 
export class Question {
  Title!: string;
  QuestionType!: string;
  QuizId!: number;
  constructor(data?: Partial<Question>) {
    if (data) {
      this.Title = data.Title || '';
      this.QuestionType = data.QuestionType || '';
      this.QuizId = data.QuizId || 0;
    }
  }
}
@Component({
  selector: 'app-question-create',
  imports: [CommonModule, ReactiveFormsModule, HttpClientModule],
  templateUrl: './question-create.component.html',
  styleUrl: './question-create.component.css'
})
export class QuestionCreateComponent 
{
  question_options:any;
 questionid: any;
  quiztype = ['MCQ', 'True/False', 'Fill in the Blanks'];
  quizid: any;
 QuestionData = new FormGroup(
    {
      Title: new FormControl(''),
      QuestionType: new FormControl('')
    }
  )
  options = new FormGroup(
    {
      Text: new FormControl(''),
      IsCorrect: new FormControl(false)
    }
  );
  
  questions: Question []=[];
  constructor(private http: HttpClient, private route: ActivatedRoute) {
    console.log(this.route.snapshot.paramMap.get('id'));
    this.quizid = this.route.snapshot.paramMap.get('id');
    console.log(this.questions)
  }

  addoption()
{
  console.log(this.options.value);
  this.http.post("https://localhost:44398/api/option/create", this.options.value, {withCredentials: true})
  .subscribe(
    response => 
    {
      console.log(response)
      if(response == "Added")
      {
        this.options.reset();
      }
    }
  )
  this.http.get(`https://localhost:44398/api/question/getbyques/${this.questionid}`, {withCredentials: true})
    .subscribe(
      response => 
      {
        this.question_options = response;
        console.log(response)
      }
    )
  
}
  addquestion()
  {
    this.http.post("https://localhost:44398/api/question/create", this.questions, {withCredentials: true})
    .subscribe(
      response => 
      {
        this.questionid = response;
        if(response.value > 0)
        {
          this.addquestionbtn = false;
        }
        console.log(response)
      }
    )
    this.http.get(`https://localhost:44398/api/question/getbyques/${this.questionid}`, {withCredentials: true})
    .subscribe(
      response => 
      {
        this.question_options = response;
        console.log(response)
      }
    )

  }
  donequestion()
  {
    this.QuestionData.reset();
    this.addquestionbtn = true;
  }
}

*/

import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { QuestionShowComponent } from "../question-show/question-show.component";

export class Question {
  Title!: string | null;
  QuestionType!: string | null;
  QuizId!: number;

  constructor(data?: Partial<Question>) {
    if (data) {
      this.Title = data.Title ?? '';
      this.QuestionType = data.QuestionType ?? '';
      this.QuizId = data.QuizId ?? 0;
    }
  }
}
export class Option {
  Text!: string | null;
  IsCorrect!: boolean | null;
  QuestionId!: number;

  constructor(data?: Partial<Option>) {
    if (data) {
      this.Text = data.Text ?? '';
      this.IsCorrect = data.IsCorrect ?? false;
      this.QuestionId = data.QuestionId ?? 0;
    }
  }
}


@Component({
  selector: 'app-question-create',
  templateUrl: './question-create.component.html',
  styleUrls: ['./question-create.component.css'],
  imports: [CommonModule, ReactiveFormsModule, HttpClientModule, QuestionShowComponent],
})
export class QuestionCreateComponent {
  quiztype = ['MCQ', 'True/False'];
  quizid: any;
  questionid: any;
  question_options: any;
  addquestionbtn = true;
  showQuestions: Question[] = [];
  showOptions: Option[] = [];

  
  QuestionData = new FormGroup({
    Title: new FormControl(''),
    QuestionType: new FormControl(''),
  });

  // Form for Options
  options = new FormGroup({
    Text: new FormControl(''),
    IsCorrect: new FormControl(false),
  });

  constructor(private http: HttpClient, private route: ActivatedRoute) {
    this.quizid = this.route.snapshot.paramMap.get('id');
    console.log('Quiz ID:', this.quizid);
  }

  findQuestion() {
    const newQuestion = new Question({
      ...this.QuestionData.value,
      QuizId: this.quizid,
    });

    this.http.get(`https://localhost:44398/api/question/getall/${this.quizid}`, {withCredentials: true,
      })
      .subscribe((response: any) => {
        this.showQuestions = response;
      });
  }
      

  addoption() {
    const newOption = new Option({
      Text: this.options.value.Text ?? '',
      IsCorrect: this.options.value.IsCorrect ?? false,
      QuestionId: this.questionid,
    });
    console.log('Options before fetch:', newOption);
    this.http.post('https://localhost:44398/api/option/create', newOption, {
      withCredentials: true,
    }).subscribe((response: any) => {
      console.log(response);
      this.addquestionbtn = false;
      this.options.reset();
      this.getQuestionOptions();
    });

  }
 addquestion() {
  const newQuestion = new Question({
    Title: this.QuestionData.value.Title ?? '',
    QuestionType: this.QuestionData.value.QuestionType ?? '',
    QuizId: this.quizid,
  });
  console.log(newQuestion);
  

  this.http.post('https://localhost:44398/api/question/create', newQuestion, {
      withCredentials: true,
    })
    .subscribe((response: any) => {
      this.questionid = response;
      console.log('Question added with ID:', this.questionid);

      this.addquestionbtn = false;
      this.QuestionData.reset();
      this.getQuestionOptions();
    });
}


  // Fetch options for the current question
  getQuestionOptions() {
    if (!this.questionid) return;
    console.log('Fetching options for Question ID:', this.questionid);
    console.log(`https://localhost:44398/api/option/getbyques/${this.questionid}`);
    this.http.get(`https://localhost:44398/api/option/getbyques/${this.questionid}`, {
        withCredentials: true,
      })
      .subscribe((response) => {
        this.question_options = response;
        console.log('Question Options:', response);
      });
  }

  // Reset the form and allow adding a new question
  donequestion() {
    this.QuestionData.reset();
    this.options.reset();
    this.addquestionbtn = true;
    this.questionid = null;
    this.question_options = null;
  }
}
