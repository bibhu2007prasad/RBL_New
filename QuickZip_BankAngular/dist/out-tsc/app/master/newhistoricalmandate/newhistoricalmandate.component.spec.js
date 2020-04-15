import { async, TestBed } from '@angular/core/testing';
import { NewhistoricalmandateComponent } from './newhistoricalmandate.component';
describe('NewhistoricalmandateComponent', function () {
    var component;
    var fixture;
    beforeEach(async(function () {
        TestBed.configureTestingModule({
            declarations: [NewhistoricalmandateComponent]
        })
            .compileComponents();
    }));
    beforeEach(function () {
        fixture = TestBed.createComponent(NewhistoricalmandateComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });
    it('should create', function () {
        expect(component).toBeTruthy();
    });
});
