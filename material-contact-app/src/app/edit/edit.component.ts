import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { DataService } from '../services/data.service';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.css']
})
export class EditComponent implements OnInit {

  constructor(private fb: FormBuilder, private service: DataService, private route: ActivatedRoute, private router: Router) { }
  public updateForm = this.fb.group({
    fname: ['', Validators.required],
    lname: ['', Validators.required],
    email: ['', Validators.required],
    city: ['', Validators.required],
    age: ['', Validators.required],
    phone: ['', Validators.required],
  });
  updateContact() {
    this.service.UpdateContact(this.route.snapshot.params['id'], this.updateForm.value).subscribe(data => {
      this.router.navigateByUrl('/');
    });
  }
  ngOnInit(): void {
    this.service.GetContact(this.route.snapshot.params['id']).subscribe((data: any) => {
      this.updateForm.setValue({
        fname: data.fname,
        lname: data.lname,
        email: data.email,
        city: data.city,
        age: data.age,
        phone: data.phone
      });
    });
  }
  get fname() { return this.updateForm.get('fname') }
  get lname() { return this.updateForm.get('lname') }
  get email() { return this.updateForm.get('email') }
  get city() { return this.updateForm.get('city') }
  get age() { return this.updateForm.get('age') }
  get phone() { return this.updateForm.get('phone') }
}
