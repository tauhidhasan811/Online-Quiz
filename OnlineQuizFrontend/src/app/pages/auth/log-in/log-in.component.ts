import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, ReactiveFormsModule } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-log-in',
  imports: [HttpClientModule, ReactiveFormsModule, CommonModule],
  templateUrl: './log-in.component.html',
  styleUrl: './log-in.component.css'
})
export class LogInComponent implements OnInit
{
  constructor(private http : HttpClient, private router: Router){}
  ngOnInit(): void 
  {
    console.log(this.userdata.value);
    this.http.post("https://localhost:44398/api/auth/validate",{},{ withCredentials: true, observe: 'response' })
    .subscribe(
      (response: any) => {
      console.log("Full response:", response);

      if (response.status === 200 && response.body?.check === 'success') {
        // store userId in sessionStorage
        sessionStorage.setItem('userid', response.body.UserId);

        // optionally store type if needed
        sessionStorage.setItem('usertype', response.body.Type);
        console.log("User logged in:", response.body.UserId);
        this.router.navigate(['quiz-show-student']);
      }
      else{
            sessionStorage.clear();
      }
      
    },
    (error) => {
      console.error("Login failed:", error);
      sessionStorage.clear();

    }
  );

  console.log(sessionStorage.getItem('userid'))
  }
  userdata = new FormGroup({
    UserName: new FormControl(''),
    Password: new FormControl('')
  });

  status: any;
  
  OnSubmit()
  {
    console.log(this.userdata.value);
    this.http.post("https://localhost:44398/api/auth/login", this.userdata.value, 
      { withCredentials: true, observe: 'response' })
    .subscribe(
      (response: any) => {
      console.log("Full response:", response);

      if (response.status === 200 && response.body?.check === 'success') 
      {
        sessionStorage.setItem('userid', response.body.UserId);
        sessionStorage.setItem('usertype', response.body.Type);
        console.log("User logged in:", response.body.UserId);
        this.router.navigate(['/quiz-show-student']);
      }
      else{
            sessionStorage.clear();
      }
      
    },
    (error) => {
      console.error("Login failed:", error);
      sessionStorage.clear();

    }
  );

  console.log(sessionStorage.getItem('userid'))
  }
}
