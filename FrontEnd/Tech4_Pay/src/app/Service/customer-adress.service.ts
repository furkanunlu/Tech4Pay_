import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CustomerAdress } from '../customer-adress/CustomerAdress';

@Injectable({
  providedIn: 'root'
})
export class CustomerAdressService {

  constructor(private http:HttpClient) { }
  patchcustomerAdress="https://localhost:5001/api/CustomerAdresses"
  getCustomerAdress():Observable<CustomerAdress[]>{
    return this.http.get<CustomerAdress[]>(this.patchcustomerAdress)}}
  
