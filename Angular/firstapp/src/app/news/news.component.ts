import { Component } from '@angular/core';
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-news',
  templateUrl: './news.component.html',
  styleUrls: ['./news.component.css']
})
export class NewsComponent {
  constructor(private service: DataService) { }
  public news: Array<any> = [];
  public keyword: string = '';
  ngOnInit() {
    this.service.GetNews(this.keyword).subscribe((data: any) => {
      this.news = data.articles;
    })
  }
  Search(){
    this.service.GetNews(this.keyword).subscribe((data: any) => {
      this.news = data.articles;
      console.log(data);
    })
  }
}

