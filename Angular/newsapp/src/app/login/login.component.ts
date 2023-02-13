import { Component } from '@angular/core';
import { FormBuilder, FormControl } from '@angular/forms';
import { Router } from '@angular/router';
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  constructor(private fb: FormBuilder, private service: DataService, private router: Router) { }
  loginForm= this.fb.group({
    email: new FormControl(''),
    password: new FormControl('')
  })
  onSubmit(){
    this.service.loginUser(this.loginForm.value).subscribe((data: any)=>{
      localStorage.setItem('token', data.access_token);
      localStorage.setItem('username', data.userData.email);
      this.router.navigateByUrl('/');
    });
  }
}
