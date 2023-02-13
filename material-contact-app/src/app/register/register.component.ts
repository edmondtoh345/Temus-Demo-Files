import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  constructor(private fb: FormBuilder, private service: DataService, private _snackBar: MatSnackBar) { }
  public registerForm = this.fb.group({
    firstname: ['', Validators.required],
    lastname: ['', Validators.required],
    email: ['', Validators.required],
    password: ['', Validators.required],
    city: ['', Validators.required],
    age: ['', Validators.required]
  });

  ngOnInit(): void {
  }
  openSnackBar(message: string) {
    this._snackBar.open(message, "Close", {
      duration: 5000,
      horizontalPosition: 'end',
      verticalPosition: 'top'
    });
  }
  register() {
    if (this.registerForm.valid) {
      this.service.RegisterUser(this.registerForm.value).subscribe((data: any) => {
        this.openSnackBar(data.message);
      }, ((error:any) => {
        this.openSnackBar(error.error.message);
      }));
    }
  }

  get firstname() { return this.registerForm.get('firstname') }
  get lastname() { return this.registerForm.get('lastname') }
  get email() { return this.registerForm.get('email') }
  get password() { return this.registerForm.get('password') }
  get city() { return this.registerForm.get('city') }
  get age() { return this.registerForm.get('age') }
}
