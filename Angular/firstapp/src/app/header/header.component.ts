import { Component } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent {
  public username: string = 'John';
  public person = {
    firstname: 'Peter',
    lastname: 'Parker'
  }
  public headingcolor: string = 'blue';
  public myStyle = {
    color: 'red',
    fontSize: '20pt',
    backgroundColor: 'yellow'
  }

  public headingClass: string = 'heading';

  public isSuccess: boolean = true;

  public headingStyle = {
    'text-danger': !this.isSuccess,
    'text-success': this.isSuccess,
    'text-decoration-line-through': this.isSuccess
  }

  public isDisabled: boolean = false;

  public defaultValue: string = "hello";

  public customername: string = 'Something';


  Show(){
    console.log('Event Triggered');
  }

  ShowStatus(event: any){
    console.log(event.target.checked);
  }

}
