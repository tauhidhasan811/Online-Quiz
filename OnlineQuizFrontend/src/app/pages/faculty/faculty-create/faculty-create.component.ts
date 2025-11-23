import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';

@Component({
  selector: 'app-faculty-create',
  standalone: true,
  imports: [ReactiveFormsModule, HttpClientModule, CommonModule],
  templateUrl: './faculty-create.component.html'
})
export class FacultyCreateComponent {
  constructor(private http : HttpClient){}
  facultydata = new FormGroup(
    {
      Name :new FormControl(""),
      UserName: new FormControl(""),
      Email: new FormControl(""),
      Password: new FormControl("")
    });

    onSubmit()
    {
      this.http.post("https://localhost:44398/api/faculty/create", this.facultydata.value, {withCredentials:true, })
      .subscribe(
        (response) =>{
          console.log(this.facultydata.value);
          console.log(response);
        }
      )
    }

}
