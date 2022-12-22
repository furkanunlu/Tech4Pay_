import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CustomerAdressComponent } from './customer-adress.component';

describe('CustomerAdressComponent', () => {
  let component: CustomerAdressComponent;
  let fixture: ComponentFixture<CustomerAdressComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CustomerAdressComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CustomerAdressComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
