import { CommonModule } from '@angular/common';
import { HttpClient, HttpClientModule } from '@angular/common/http';
import { Component } from '@angular/core';
import { Router, RouterLink, RouterOutlet } from '@angular/router';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, RouterLink, CommonModule, HttpClientModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  get usertype(): string | null {
    console.log(sessionStorage.getItem('usertype'));
    return sessionStorage.getItem('usertype');

  }
  title = 'OnlineQuizFrontend';
  get userId(): string | null {
    return sessionStorage.getItem('userid');
  }
  constructor(private http: HttpClient, private router: Router){}
  logOut()
  {
    this.http.post("https://localhost:44398/api/auth/logout", {},{withCredentials: true, observe:"response" })
    .subscribe(
      (response) =>
      {
        console.log(response);
        if(response.status == 200)
        {
          this.router.navigate(['/log-in']);
        }
      }
    );
  }
}
