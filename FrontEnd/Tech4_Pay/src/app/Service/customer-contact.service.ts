import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { CustomerContact } from '../customer-contact/CustomerContact';

@Injectable({
  providedIn: 'root'
})
export class CustomerContactService {

  constructor(private http:HttpClient) { }
  patchcustomerContact='https://localhost:5001/api/CustomerContacts';
  getCustomerContact():Observable<CustomerContact[]>{
    return this.http.get<CustomerContact[]>(this.patchcustomerContact)}}

