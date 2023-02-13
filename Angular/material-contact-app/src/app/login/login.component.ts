import { Component } from '@angular/core';
import { FormBuilder, FormControl, Validators } from '@angular/forms';
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  constructor(private fb: FormBuilder, private service: DataService) { }
  loginForm = this.fb.group({
    email: new FormControl('', Validators.required),
    password: new FormControl('', Validators.required),
  })

  onSubmit(){
    this.service.login(this.loginForm.value).subscribe((data: any) => {
      localStorage.setItem('token', data.access_token);
    });
  }

  get email() { return this.loginForm.get('email') }
  get password() { return this.loginForm.get('password') }
}

