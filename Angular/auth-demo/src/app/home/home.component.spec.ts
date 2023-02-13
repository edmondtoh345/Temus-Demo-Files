import { ComponentFixture, TestBed } from '@angular/core/testing';
import { PhonePipe } from '../phone.pipe';

import { HomeComponent } from './home.component';

describe('HomeComponent', () => {
  let component: HomeComponent;
  let fixture: ComponentFixture<HomeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HomeComponent, PhonePipe ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HomeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
  it('heading should have "Welcome" text', ()=>{
    let elem = fixture.nativeElement as HTMLElement;
    expect(elem.querySelector('.text-primary')?.textContent).toContain('Welcome');
  })
});
