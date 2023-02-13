import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent {
  constructor(private service: DataService, private route: Router) { }
  public username: string = '';
  public isLoggedIn: boolean = false;
  public header: string='Contact Manager';

  show(){
    return 'Hello';
  }
  ngOnInit() {
    this.service.usernameSubject.subscribe((data: any) => this.username = data);
    this.service.isLoggedInSubject.subscribe((data: any) => this.isLoggedIn = data);
  }

  onLogout(){
    localStorage.clear();
    this.route.navigateByUrl('/');
    this.service.isLoggedInSubject.next(false);
  }
}
