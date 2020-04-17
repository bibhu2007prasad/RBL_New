import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UsersetupComponent } from './usersetup.component';

describe('UsersetupComponent', () => {
  let component: UsersetupComponent;
  let fixture: ComponentFixture<UsersetupComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UsersetupComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UsersetupComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
