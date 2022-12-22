import { Component, OnInit } from '@angular/core';
import { CustomerAdressService } from '../Service/customer-adress.service';
import { CustomerAdress } from './CustomerAdress';

@Component({
  selector: 'app-customer-adress',
  templateUrl: './customer-adress.component.html',
  styleUrls: ['./customer-adress.component.css']
})
export class CustomerAdressComponent implements OnInit {
  constructor(private kategoriService:CustomerAdressService) { }
  name = "Kişiler";
  
  customerAdress : CustomerAdress []; 
  ngOnInit(): void {
    this.kategoriService.getCustomerAdress().subscribe(p=>{
      this.customerAdress =p});


  }

}
