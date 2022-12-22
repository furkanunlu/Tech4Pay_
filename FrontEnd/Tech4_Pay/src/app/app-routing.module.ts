import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CustomerAdressComponent } from './customer-adress/customer-adress.component';
import { CustomerContactComponent } from './customer-contact/customer-contact.component';
import { CustomerComponent } from './customer/customer.component';

const routes: Routes = [{path:'customer',component:CustomerComponent},
{path:'customerAdress',component:CustomerAdressComponent},
{path:'customerContact',component:CustomerContactComponent}];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
