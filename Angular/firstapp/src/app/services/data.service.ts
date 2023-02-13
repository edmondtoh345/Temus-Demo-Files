import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DataService {

  constructor(private http: HttpClient) { }

  Factorial(num: number) {
    let fact = 1;
    for (let i = 1; i <= num; i++) {
      fact = fact * i;
    }
    return fact;
  }

  Sum(a: number, b: number) {
    return a + b;
  }

  GetData() {
    return this.http.get('https://jsonplaceholder.typicode.com/users')
  }

  GetNews(keyword: string){
    return this.http.get(`https://newsapi.org/v2/top-headlines?country=sg&q=${keyword}&apiKey=819b763010e64f5790392a15d2b28047`)
  }

}
