import { Component } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  public fruits: Array<string> = ['Apple', 'Mango', 'Banana', 'Cherry'];
  public products: Array<any> = [
    { name: 'Laptop', brand: 'Dell', price: 699 },
    { name: 'Camera', brand: 'Canon', price: 399 },
    { name: 'Desktop', brand: 'HP', price: 499 },
    { name: 'Tablet', brand: 'Lenovo', price: 199 },
    { name: 'Monitor', brand: 'LG', price: 299 },
    { name: 'Pendrive', brand: 'kingston', price: 59 }
  ];

  public day: number = 1;
}
