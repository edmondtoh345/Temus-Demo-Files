import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(private http: HttpClient) { }

  register(user: any){
    return this.http.post('http://localhost:9000/auth/register', user);
  }

  login(credentials: any){
    return this.http.post('http://localhost:9000/auth/login', credentials);
  }

  isTokenValid(){
    return this.http.post('http://localhost:9000/auth/isAuthenticated', null, {
      headers:{
        'Authorization': `Bearer ${localStorage.getItem('token')}`
      }
    });
  }
}
