import { Component, EventEmitter, Input, Output } from '@angular/core';

@Component({
  selector: 'app-child',
  templateUrl: './child.component.html',
  styleUrls: ['./child.component.css']
})
export class ChildComponent {
  @Input()
  public fname: string = '';

  @Output()
  public myevent = new EventEmitter();

  Show() {
    this.myevent.emit('Melody');
  }
}
