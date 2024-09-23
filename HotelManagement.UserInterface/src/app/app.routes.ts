import { RouterModule, Routes } from '@angular/router';
import { LoginPageComponent } from './login-page/login-page.component';
import { NgModule } from '@angular/core';
import { SignupPageComponent } from './signup-page/signup-page.component';

export const routes: Routes = [
    {path:'',component:LoginPageComponent},
    {path:'signup',component:SignupPageComponent}
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
  })

  export class AppRoutingModule{}