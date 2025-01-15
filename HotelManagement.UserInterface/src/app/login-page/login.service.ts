import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class LoginService {

  constructor() 
  {

  }


  DoLoging(userID:string, password:string) : void
  {
      //localStorage.setItem("userID")
  }

  // This method is used for login and will return the bearer token that would be stored in local storage
  Login() : string
  {
    
     return "";
  }
}
