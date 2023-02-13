import { Component } from '@angular/core';
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent {
  constructor(private service: DataService) { }

  public result: number = 0;
  public userInput: number = 1;
  public users: Array<any> = [];
  ngOnInit() {
    this.service.GetData().subscribe((data: any) => {
      this.users = data;
    });
  }

  Calculate() {
    this.result = this.service.Factorial(this.userInput);
  }
}
