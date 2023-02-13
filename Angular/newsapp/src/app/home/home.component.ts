import { Component } from '@angular/core';
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent {
  constructor(private service: DataService) { }
  public news: any;
  ngOnInit() {
    this.service.getNews().subscribe((data: any) => {
      this.news = data.articles;
      console.log(this.news);
    });
  }

  AddToFavorites(data: any) {
    // Using spread operator to add new property email into data object
    this.service.addNews({...data, email: localStorage.getItem('username')}).subscribe((data: any) => {
      alert('Added to Favorites');
    });
  }
}
