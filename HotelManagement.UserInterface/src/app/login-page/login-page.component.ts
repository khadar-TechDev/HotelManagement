import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login-page',
  standalone: true,
  imports: [],
  templateUrl: './login-page.component.html',
  styleUrl: './login-page.component.css'
})
export class LoginPageComponent
{
  constructor(private router:Router)
  {

  }
  userIDPlaceHolder:string = "Enter your user ID"
  passwordPlaceHolder:string = "Enter your password"

  signupclick()
  {
    this.router.navigate(['/signup'])
  }
}
