import { Component } from '@angular/core';
import { DataService } from './services/data.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'fullstack-api-call';
  constructor(private service: DataService) { }
  ngOnInit() {
    this.service.getCustomers().subscribe((data: any)=>{
      console.log(data);
    })
  }
}
