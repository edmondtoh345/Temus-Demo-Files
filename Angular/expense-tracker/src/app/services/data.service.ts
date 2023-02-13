import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from "../../environment/environment";
@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(private http: HttpClient) { }

  addTransaction(trans: any) {
    return this.http.post(environment.apiUrl, trans);
  }

  getTransactions() {
    return this.http.get(environment.apiUrl);
  }

  deleteTransaction(id: number) {
    return this.http.delete(`${environment.apiUrl}/${id}`);
  }
}
