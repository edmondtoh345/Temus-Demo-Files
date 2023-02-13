import { Component } from '@angular/core';
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-favorites',
  templateUrl: './favorites.component.html',
  styleUrls: ['./favorites.component.css']
})
export class FavoritesComponent {
  constructor(private service: DataService) { }
  public fav: any;
  ngOnInit() {
    this.service.getFavorites(localStorage.getItem('username')).subscribe((data: any) => this.fav = data);
  }
}
