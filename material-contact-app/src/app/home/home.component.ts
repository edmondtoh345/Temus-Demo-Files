import { Component, OnInit } from '@angular/core';
import Contact from '../models/contact';
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  constructor(private service: DataService) { }
  public contacts: any;
  ngOnInit(): void {
    this.service.GetContacts().subscribe((data: any) => {
      this.contacts = data;
    });
  }

}
