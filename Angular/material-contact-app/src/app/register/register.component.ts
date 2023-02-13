import { Component } from '@angular/core';
import { FormBuilder, FormControl, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent {

  constructor(private fb: FormBuilder, private service: DataService, private _snackBar: MatSnackBar) { }
  // public fname = new FormControl('', [Validators.required, Validators.minLength(4), Validators.maxLength(10)]);
  // public lname = new FormControl('', Validators.required);
  // public email = new FormControl('', [Validators.required, Validators.email]);
  // public password = new FormControl('', Validators.required);
  registerForm = this.fb.group({
    firstname: new FormControl(null, {validators: [Validators.required, Validators.minLength(4)], updateOn: "blur"}),
    lastname: new FormControl('', Validators.required),
    email: new FormControl('', Validators.required),
    password: new FormControl('', Validators.required),
    city: new FormControl('', Validators.required),
    age: new FormControl('', Validators.required),
  })

  openSnackBar(message: string, action: string) {
    this._snackBar.open(message, action, {horizontalPosition: 'right', verticalPosition: 'bottom'});
  }

  onSubmit(){
    if(this.registerForm.valid){
      this.service.register(this.registerForm.value).subscribe(data => console.log(data));
    }else{
      this.openSnackBar('Something went wrong', 'Close');
    }
  }

  get firstname() { return this.registerForm.get('firstname') }
  get lastname() { return this.registerForm.get('lastname') }
  get email() { return this.registerForm.get('email') }
  get password() { return this.registerForm.get('password') }
  get city() { return this.registerForm.get('city') }
  get age() { return this.registerForm.get('age') }

} 
