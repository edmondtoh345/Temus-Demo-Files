import { Component } from '@angular/core';
import Contact from '../models/contact';
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  constructor(private service: DataService) { }
  public contact: Contact = {};
  public updateContact: Contact = {};
  public contacts: Array<any> = [];
  ngOnInit() {
    this.service.GetContacts().subscribe((data: any) => this.contacts = data);
  }

  AddContact() {
    this.service.AddContact(this.contact).subscribe(data => {
      this.contacts.push(this.contact);
      this.contact = {};
    });
  }

  DeleteContact(id: any) {
    this.service.DeleteContact(id).subscribe(data => {
      this.contacts = this.contacts.filter(x => x.id !== id);
    });
  }
  GetContact(id: any) {
    this.service.GetContact(id).subscribe(data => {
      this.updateContact = data;
    });
  }

  UpdateContact() {
    this.service.UpdateContact(this.updateContact.id, this.updateContact).subscribe(data => {
      let result = this.contacts.find(x => x.id == this.updateContact.id);
      let i = this.contacts.indexOf(result);
      this.contacts[i] = data;
    });
  }
}
