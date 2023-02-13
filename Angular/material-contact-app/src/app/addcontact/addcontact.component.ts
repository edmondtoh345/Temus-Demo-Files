import { Component } from '@angular/core';
import { NgForm } from '@angular/forms';
import Contact from '../models/contact';

@Component({
  selector: 'app-addcontact',
  templateUrl: './addcontact.component.html',
  styleUrls: ['./addcontact.component.css']
})
export class AddcontactComponent {
  public con: Contact = {};

  onSubmit(contactForm: NgForm) {
    if(contactForm.form.valid){
      console.log(contactForm.form.value);
    }else{
      console.log('Something went wrong')
    }
  }
}
