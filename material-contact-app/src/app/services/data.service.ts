import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import Contact from '../models/contact';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(private http: HttpClient) { }

  AddContact(contact: Contact) {
    return this.http.post('http://localhost:3000/contacts', contact);
  }

  UpdateContact(id: number, contact: any){
    return this.http.put(`http://localhost:3000/contacts/${id}`, contact);
  }

  GetContacts() {
    return this.http.get('http://localhost:3000/contacts');
  }

  GetContact(id: number) {
    return this.http.get(`http://localhost:3000/contacts/${id}`);
  }

  RegisterUser(user: any) {
    return this.http.post('http://localhost:9000/auth/register', user);
  }

  LoginUser(user: any) {
    return this.http.post('http://localhost:9000/auth/login', user);
  }

  IsAuthenticated(token) {
    return this.http.post('http://localhost:9000/auth/isAuthenticated', null, {
      headers: {
        'Authorization': `Bearer ${token}`
      }
    });
  }
}
