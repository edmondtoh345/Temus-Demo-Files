import { Component } from '@angular/core';

@Component({
  selector: 'app-parent',
  templateUrl: './parent.component.html',
  styleUrls: ['./parent.component.css']
})
export class ParentComponent {
  public firstname: string = 'Dhiraj';
  public fname: string = '';
  parentShow(value: any) {
    this.fname = value;
  }
}
