import { Component } from '@angular/core';
import { MatSnackBar } from "@angular/material/snack-bar";
import { DataService } from './services/data.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'material-contact-app';
  constructor(private _snackBar: MatSnackBar, private service: DataService) { }
  // openSnackBar(message: string, action: string) {
  //   this._snackBar.open(message, action);
  // }
  openSnackBar() {
    this._snackBar.open("Welcome to Angular Material", "Close", {
      duration: 3000,
      horizontalPosition: 'end',
      verticalPosition: 'top'
    });
  }
}
