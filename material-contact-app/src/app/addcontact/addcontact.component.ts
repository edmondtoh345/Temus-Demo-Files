import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';
import { Router } from '@angular/router';
import Contact from '../models/contact';
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-addcontact',
  templateUrl: './addcontact.component.html',
  styleUrls: ['./addcontact.component.css']
})
export class AddcontactComponent implements OnInit {

  constructor(private service: DataService, private route: Router) { }
  public contact = new Contact();
  ngOnInit(): void {
  }

  onSubmit(form: NgForm) {
    if (form.valid) {
      this.service.AddContact(form.value).subscribe(data => {
        this.route.navigate(['/']);
      });
    }
  }

}
