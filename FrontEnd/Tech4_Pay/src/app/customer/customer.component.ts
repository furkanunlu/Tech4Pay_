import { Component, OnInit } from '@angular/core';
import { Customer } from "./Customer.1";
import { HttpClient, HttpClientModule } from '@angular/common/http'
import { tap } from 'rxjs';
import { KategoriService } from '../Service/kategori.service';

@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css'],
  providers:[KategoriService]
})

export class CustomerComponent implements OnInit {
  constructor(private http: HttpClient,private kategoriService:KategoriService) { }
  name = "Kişiler";
  public patch='https://localhost:5001/api/Customers';
  
  customers :Customer[];
  posts : any;
  ngOnInit(): void {
    this.kategoriService.getCustomer().subscribe(data=>{
      this.customers=data
    })
    
    
    
  }
  
  
  
}
