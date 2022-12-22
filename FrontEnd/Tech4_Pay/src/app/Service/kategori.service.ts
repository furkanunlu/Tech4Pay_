import { HttpClient,HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Customer } from "../customer/Customer.1";


@Injectable({
  providedIn: 'root'
})
export class KategoriService {

  constructor(private http:HttpClient) { }

  apiURL = 'https://localhost:5001/api/';
  getCustomer(): Observable<Customer[]> {
      return this.http.get<Customer[]>(this.apiURL+"Customers");
    }
  }