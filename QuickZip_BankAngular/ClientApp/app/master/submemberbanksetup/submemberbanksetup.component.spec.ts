import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SubmemberbanksetupComponent } from './submemberbanksetup.component';

describe('SubmemberbanksetupComponent', () => {
  let component: SubmemberbanksetupComponent;
  let fixture: ComponentFixture<SubmemberbanksetupComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SubmemberbanksetupComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SubmemberbanksetupComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
