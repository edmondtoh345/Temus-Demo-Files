import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})
export class DashboardComponent {

  @Input()
  public childUserName: string = '';

  @Output()
  public childEvent = new EventEmitter();

  PassValue(value: string) {
    this.childEvent.emit(value);
  }
}
