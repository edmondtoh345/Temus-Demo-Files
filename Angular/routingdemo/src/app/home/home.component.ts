import { Component } from '@angular/core';
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  constructor(private service: DataService) { }
  public userlist: Array<any> = [];
  ngOnInit() {
    this.service.GetData().subscribe((users: any) => {
      this.userlist = users.data;
    });
  }
}
