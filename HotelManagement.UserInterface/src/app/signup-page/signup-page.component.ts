import { Component, DoCheck } from '@angular/core';
import { Router } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';


@Component({
  selector: 'app-signup-page',
  standalone: true,
  imports: [FormsModule,CommonModule],
  templateUrl: './signup-page.component.html',
  styleUrl: './signup-page.component.css'
})
export class SignupPageComponent implements DoCheck{

  constructor(private router:Router)
  {

  }

  ngDoCheck(): void {
    console.log("do check ")
     this.passwordsMatch = this.password === this.confirmPassword;
  }
  
  userNamePH:string = "Enter your user Name"
  emailPH:string = "Enter your email ID"
  organizationPH:string = "Enter your Sales Organization"
  mobileePH:string = "Enter your Mobile no."
  subscriptionPH:string = "Enter your Subscription"
  passwordPH:string = "Password"
  confirmPasswordPH:string = "Confirm password"

  userName = "";
  emailID = "";
  organization = "";
  mobile = "";
  subscription = "";
  password = "";
  confirmPassword = "";
  passwordsMatch = true;


  signupclick()
  {
    console.log("this method is being called.")
    console.log(this.userName)
    this.router.navigate(['/signup'])
  }
  
}
