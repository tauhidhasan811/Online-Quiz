import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-student-create',
  imports: [ReactiveFormsModule, HttpClientModule ],
  templateUrl: './student-create.component.html'
})
export class StudentCreateComponent {
  

  StudentData = new FormGroup({
    Name: new FormControl(''),
    UserName: new FormControl(''),
    Email: new FormControl(''),
    Password : new FormControl(''),
  })
  constructor(private http: HttpClient){}

  onSubmit()
  {
    this.http.post("https://localhost:44398/api/student/create", this.StudentData.value)
    .subscribe(
      (response) =>
      {
        console.log(response)
      }
    );
  }

}
