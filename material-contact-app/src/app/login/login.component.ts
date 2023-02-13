import { Component, OnInit } from '@angular/core';
import { FormControl, Validators } from '@angular/forms';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Router } from '@angular/router';
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private service: DataService, private route: Router, private _snackBar: MatSnackBar) { }
  public username = new FormControl('', Validators.required);
  public password = new FormControl('', [Validators.required, Validators.maxLength(10)]);
  ngOnInit(): void {
  }
  openSnackBar(message: string) {
    this._snackBar.open(message, "Close", {
      duration: 3000,
      horizontalPosition: 'end',
      verticalPosition: 'top'
    });
  }
  onSubmit() {
    if (this.username.valid && this.password.valid) {
      this.service.LoginUser({ email: this.username.value, password: this.password.value }).subscribe((data: any) => {
        localStorage.setItem('token', data.access_token);
        this.route.navigateByUrl('/');
      }, (error: any) => {
        this.openSnackBar(error.error.message);
      });
    }
  }

}
