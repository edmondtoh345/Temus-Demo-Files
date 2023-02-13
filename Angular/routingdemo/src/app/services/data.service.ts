import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(private http: HttpClient) { }
  GetData() {
    return this.http.get('https://dummyapi.io/data/v1/user?limit=20',{
      headers:{
        'app-id': '61d42dff81395d74a1d00055'
      }
    })
  }

  GetProfileData(id: string){
    return this.http.get(`https://dummyapi.io/data/v1/user/${id}`,{
      headers:{
        'app-id': '61d42dff81395d74a1d00055'
      }
    })
  }
}
