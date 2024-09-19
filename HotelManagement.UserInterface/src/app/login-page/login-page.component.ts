import { Component } from '@angular/core';

@Component({
  selector: 'app-login-page',
  standalone: true,
  imports: [],
  templateUrl: './login-page.component.html',
  styleUrl: './login-page.component.css'
})
export class LoginPageComponent
{
userIDPlaceHolder:string = "Enter your user ID"
passwordPlaceHolder:string = "Enter your password"


}
