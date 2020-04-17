import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UserrolesetupComponent } from './userrolesetup.component';

describe('UserrolesetupComponent', () => {
  let component: UserrolesetupComponent;
  let fixture: ComponentFixture<UserrolesetupComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UserrolesetupComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UserrolesetupComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
