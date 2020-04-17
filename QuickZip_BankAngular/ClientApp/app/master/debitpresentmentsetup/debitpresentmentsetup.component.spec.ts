import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { DebitpresentmentsetupComponent } from './debitpresentmentsetup.component';

describe('DebitpresentmentsetupComponent', () => {
  let component: DebitpresentmentsetupComponent;
  let fixture: ComponentFixture<DebitpresentmentsetupComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DebitpresentmentsetupComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DebitpresentmentsetupComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
