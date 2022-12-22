import { Component } from '@angular/core';
import { CustomerContactService } from '../Service/customer-contact.service';
import { CustomerContact } from './CustomerContact';

@Component({
  selector: 'app-customer-contact',
  templateUrl: './customer-contact.component.html',
  styleUrls: ['./customer-contact.component.css']
})
export class CustomerContactComponent {
  constructor(private ContactService:CustomerContactService){}
  customerContact : CustomerContact[];
  ngOnInit(): void{
      this.ContactService.getCustomerContact().subscribe(p=>{
        this.customerContact=p});
  }
}
