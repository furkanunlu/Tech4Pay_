import { TestBed } from '@angular/core/testing';

import { CustomerAdressService } from './customer-adress.service';

describe('CustomerAdressService', () => {
  let service: CustomerAdressService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CustomerAdressService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
