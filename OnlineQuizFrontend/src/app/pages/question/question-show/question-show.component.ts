import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Route } from '@angular/router';
import { QuestionUpdateComponent } from '../question-update/question-update.component';
import { FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-question-show',
  imports: [ HttpClientModule, CommonModule, QuestionUpdateComponent, ReactiveFormsModule],
  templateUrl: './question-show.component.html',
  styleUrl: './question-show.component.css'
})

export class QuestionShowComponent implements OnInit {
  
@Input() quizid!: number;  
  usertype:any;
  
  constructor(private http :HttpClient, private route: ActivatedRoute){}
  questions: any;
  questionsId : Int32List[] = [];
  options: any;
  UpdateOptionFormGroup!: FormGroup;
  
  ngOnInit(): void {
    this.usertype = sessionStorage.getItem('usertype');
    console.log(this.usertype);
    if (!this.quizid) {
      const routeId = this.route.snapshot.paramMap.get('id');
      if (routeId) {
        this.quizid = +routeId; // convert string to number
      }
    }
    console.log(this.quizid);
 this.http.get(`https://localhost:44398/api/question/getall/${this.quizid}`, { withCredentials: true })
  .subscribe((response: any) => {
    this.questions = response;
    if (response != null) {
      for (let q of this.questions) {
        this.questionsId.push(q.Id);

        this.http.get(`https://localhost:44398/api/option/getbyques/${q.Id}`, { withCredentials: true })
          .subscribe((optRes) => {
            if (!this.options) this.options = [];  
            console.log(optRes);
            this.options.push(optRes);
          });
      }
      console.log(this.questionsId);
      console.log(this.options);
    }
  });
  this.UpdateOptionFormGroup = new FormGroup({
      Text: new FormControl(''),
      IsAnswer: new FormControl(false),
    });

  }
      selectedAnswers: { questionId: number, optionId: number }[] = [];
      selectedOptionId: any[] = [];
  onSelectAnswer(questionId: number, optionId: number) {
  // Check if this question already has an answer stored
  const existing = this.selectedAnswers.find(ans => ans.questionId === questionId);

  if (existing) {
    // Update the answer
    existing.optionId = optionId;
  } else {
    // Add new answer
    this.selectedAnswers.push({ questionId, optionId });
  }

  console.log(this.selectedAnswers); //
}

submitAnswers() 
{
  this.selectedOptionId = []; 
  let squizid = sessionStorage.getItem('quizid');
  console.log(squizid);
  for (let ans of this.selectedAnswers) {
    this.selectedOptionId.push(ans.optionId);
  }
  console.log(this.selectedOptionId); //
  this.http.post('https://localhost:44398/api/studentquiz/update', {squizid: squizid, answers: this.selectedOptionId }, { withCredentials: true })
    .subscribe(
      (response) => {
        console.log('Answers submitted successfully', response);
        sessionStorage.removeItem('quizid');
      },
      (error) => {
        console.error('Error submitting answers', error);
      }
    );
  }
  editquestion: boolean = false;
  editoption: boolean= false;

    editQuestion(id: number) {
      this.editquestion = true;

    }
    
    editiedOptionData: any;
    editOption(id: number) 
    { 
      console.log(`https://localhost:44398/api/option/get/${id}`);
      this.editoption = true; 
      this.http.get(`https://localhost:44398/api/option/get/${id}`, { withCredentials: true })
      .subscribe((response: any) => {
        this.editiedOptionData = response;
        console.log("Finded Option: ",response);
      });
    }
    updateOption(editiedOptionData: any) {
      editiedOptionData.Text = this.UpdateOptionFormGroup.value.Text;
      editiedOptionData.IsAnswer = this.UpdateOptionFormGroup.value.IsAnswer;
      console.log(editiedOptionData);
      this.http.put(`https://localhost:44398/api/option/update`, editiedOptionData, { withCredentials: true })
        .subscribe((response) => {
          console.log('Option updated successfully', response);
        });
    }

}
