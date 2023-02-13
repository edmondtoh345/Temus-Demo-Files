import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-profile',
  templateUrl: './profile.component.html',
  styleUrls: ['./profile.component.css']
})
export class ProfileComponent {
  constructor(private route: ActivatedRoute, private service: DataService) { }
  public profiledata: any;
  ngOnInit(){
    this.service.GetProfileData(this.route.snapshot.params['id']).subscribe(data => {
      this.profiledata=data;
      console.log(data);
    });
  }
}
