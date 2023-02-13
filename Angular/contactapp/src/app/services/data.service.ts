import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import Contact from "../models/contact";
@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(private http: HttpClient) { }

  AddContact(data: Contact) {
    return this.http.post('http://localhost:3000/contacts', data);
  }

  GetContacts(){
    return this.http.get('http://localhost:3000/contacts');
  }

  DeleteContact(id: any){
    return this.http.delete(`http://localhost:3000/contacts/${id}`);
  }

  GetContact(id: any){
    return this.http.get(`http://localhost:3000/contacts/${id}`);
  }

  UpdateContact(id: any, contact: Contact){
    return this.http.put(`http://localhost:3000/contacts/${id}`, contact);
  }
}
