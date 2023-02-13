import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Subject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(private http: HttpClient) { }
  public usernameSubject = new BehaviorSubject('Guest');
  public isLoggedInSubject = new BehaviorSubject(false);
  register(user: any) {
    return this.http.post('http://localhost:9000/auth/register', user);
  }

  login(cred: any) {
    return this.http.post('http://localhost:9000/auth/login', cred);
  }

  isTokenValid() {
    return this.http.post('http://localhost:9000/auth/isAuthenticated', null, {
      headers: {
        'Authorization': `Bearer ${localStorage.getItem('token')}`
      }
    })
  }

}
