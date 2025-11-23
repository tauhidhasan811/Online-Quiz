import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-faculty-show',
  imports: [HttpClientModule, CommonModule],
  templateUrl: './faculty-show.component.html',
  styleUrl: './faculty-show.component.css'
})
export class FacultyShowComponent {
  
  constructor(private http :HttpClient, private router: Router){}
  faculties: any;

  status: any;
  ngOnInit()
  {
    
    this.http.get("https://localhost:44398/api/faculty/getall",
      {withCredentials:true, observe: 'response'} )
    .subscribe(
      res =>
      {
        this.faculties = res.body;
        this.status = res.status;
        console.log(res, res.status)
      },
      error =>
      {
        console.log(error, error.status)
        this.status = error.status;
        if (this.status === 401) {
        console.log("Unauthorized, redirecting...");
        this.router.navigate(['/log-in']); // use navigate, not createUrlTree
      }
        
      }
    );

    
    
  }

}
