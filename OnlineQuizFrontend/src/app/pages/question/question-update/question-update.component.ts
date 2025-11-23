import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, Input, OnInit } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-question-update',
  imports: [HttpClientModule, ReactiveFormsModule],
  templateUrl: './question-update.component.html',
  styleUrl: './question-update.component.css'
})
export class QuestionUpdateComponent implements OnInit {
  @Input() questionid!: number;
  question: any;
  QuestionData!: FormGroup;

  constructor(private http: HttpClient) { }
  
   ngOnInit(): void {
    this.http.get(`https://localhost:44398/api/question/get/${this.questionid}`, { withCredentials: true })
      .subscribe((response: any) => {
        this.question = response;
        console.log(response);
        this.QuestionData = new FormGroup({
          Title: new FormControl(this.question?.Title),
          QuestionType: new FormControl(this.question?.QuestionType),
        });
      });
    }

  updatequestion()
  {
    this.question.Title = this.QuestionData.value.Title;
    this.question.QuestionType = this.QuestionData.value.QuestionType;
    console.log(this.question);
    this.http.put(`https://localhost:44398/api/question/update`, this.question, { withCredentials: true })
    .subscribe(
      response => 
      {
        console.log(response)
      }
    )
  }


}
