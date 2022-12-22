import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http'
import { CustomerComponent } from './customer/customer.component';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { CustomerAdressComponent } from './customer-adress/customer-adress.component';
import { CustomerContactComponent } from './customer-contact/customer-contact.component';

@NgModule({
    declarations: [
        AppComponent,CustomerComponent,CustomerAdressComponent,CustomerContactComponent
    ],
    providers: [],
    bootstrap: [AppComponent],
    imports: [
        BrowserModule,
        AppRoutingModule,
        HttpClientModule,
        
    ]
})
export class AppModule { }
