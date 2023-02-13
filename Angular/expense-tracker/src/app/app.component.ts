import { Component } from '@angular/core';
import { FormBuilder, FormControl } from '@angular/forms';
import { DataService } from './services/data.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'expense-tracker';
  constructor(private service: DataService, private fb: FormBuilder) { }
  public transactions: Array<any> = [];
  public income: number = 0;
  public expense: number = 0;
  trackerForm = this.fb.group({
    amount: new FormControl(''),
    description: new FormControl(''),
    date: new FormControl(''),
    category: new FormControl()
  })

  ngOnInit() {
    this.service.getTransactions().subscribe((data: any) => {
      this.transactions = data;
      this.transactions.map((data) => {
        if (data.category == "Income") {
          this.income += data.amount;
        } else if (data.category == "Expense") {
          this.expense += data.amount;
        }
      })
    })
  }

  AddTransaction() {
    this.service.addTransaction(this.trackerForm.value).subscribe((data: any) => {
      this.transactions.push(data);
      this.calculate(data.category);
      this.trackerForm.reset();
    })
  }

  DeleteTransaction(id: any) {
    this.service.deleteTransaction(id).subscribe((data: any) => {
      this.transactions = this.transactions.filter(x => x.id !== id);
    })
  }

  calculate(type: string) {
    this.transactions.map((data) => {
      if (type == "Income") {
        this.income += data.amount;
      } else if (type == "Expense") {
        this.expense += data.amount;
      }else{
        this.income += data.amount;
        this.expense += data.amount;
      }
    });
  }
}
