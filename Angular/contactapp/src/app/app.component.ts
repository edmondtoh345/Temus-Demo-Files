import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'contactapp';

  public username: string = 'Steve';
  public customername: string = '';
  Show(event: any) {
    this.customername = event;
  }
}
