import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../environment/environment';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(private http: HttpClient) { }

  getNews(){
    return this.http.get(environment.apiUrl);
  }

  addNews(data: any){
    return this.http.post(environment.jsonUrl, data);
  }

  getFavorites(email: any){
    return this.http.get(`${environment.jsonUrl}?email=${email}`);
  }

  registerUser(user: any){
    return this.http.post(`${environment.authUrl}/register`, user);
  }

  loginUser(cred: any){
    return this.http.post(`${environment.authUrl}/login`, cred);
  }

  isAuthenticated(){
    return this.http.post(`${environment.authUrl}/isAuthenticated`, null, {
      headers:{
        'Authorization': `Bearer ${localStorage.getItem('token')}`
      }
    });
  }
}
