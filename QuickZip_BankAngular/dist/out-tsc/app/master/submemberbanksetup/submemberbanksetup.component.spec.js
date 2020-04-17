import { async, TestBed } from '@angular/core/testing';
import { SubmemberbanksetupComponent } from './submemberbanksetup.component';
describe('SubmemberbanksetupComponent', function () {
    var component;
    var fixture;
    beforeEach(async(function () {
        TestBed.configureTestingModule({
            declarations: [SubmemberbanksetupComponent]
        })
            .compileComponents();
    }));
    beforeEach(function () {
        fixture = TestBed.createComponent(SubmemberbanksetupComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });
    it('should create', function () {
        expect(component).toBeTruthy();
    });
});
