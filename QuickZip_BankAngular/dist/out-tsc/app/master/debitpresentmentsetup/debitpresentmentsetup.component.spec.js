import { async, TestBed } from '@angular/core/testing';
import { DebitpresentmentsetupComponent } from './debitpresentmentsetup.component';
describe('DebitpresentmentsetupComponent', function () {
    var component;
    var fixture;
    beforeEach(async(function () {
        TestBed.configureTestingModule({
            declarations: [DebitpresentmentsetupComponent]
        })
            .compileComponents();
    }));
    beforeEach(function () {
        fixture = TestBed.createComponent(DebitpresentmentsetupComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });
    it('should create', function () {
        expect(component).toBeTruthy();
    });
});
