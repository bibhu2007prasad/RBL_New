import { async, TestBed } from '@angular/core/testing';
import { SettlementTypeMasterComponent } from './settlement-type-master.component';
describe('SettlementTypeMasterComponent', function () {
    var component;
    var fixture;
    beforeEach(async(function () {
        TestBed.configureTestingModule({
            declarations: [SettlementTypeMasterComponent]
        })
            .compileComponents();
    }));
    beforeEach(function () {
        fixture = TestBed.createComponent(SettlementTypeMasterComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });
    it('should create', function () {
        expect(component).toBeTruthy();
    });
});
