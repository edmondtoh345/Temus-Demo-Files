import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UpdatecontactComponent } from './updatecontact.component';

describe('UpdatecontactComponent', () => {
  let component: UpdatecontactComponent;
  let fixture: ComponentFixture<UpdatecontactComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UpdatecontactComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(UpdatecontactComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
