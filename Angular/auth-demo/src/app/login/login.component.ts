import { Component } from '@angular/core';
import { FormBuilder, FormControl } from '@angular/forms';
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  constructor(private fb: FormBuilder, private service: DataService){}

  loginForm = this.fb.group({
    email: new FormControl(''),
    password: new FormControl('')
  })

  onSubmit(){
    this.service.login(this.loginForm.value).subscribe((data: any)=>{
      localStorage.setItem('token', data.access_token);
      this.service.usernameSubject.next(data.userData.firstname);
      this.service.isLoggedInSubject.next(true);
      console.log(data);
    })
  }
}
