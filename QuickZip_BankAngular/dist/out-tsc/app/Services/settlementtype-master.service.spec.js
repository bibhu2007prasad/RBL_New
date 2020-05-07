import { TestBed } from '@angular/core/testing';
import { SettlementtypeMasterService } from './settlementtype-master.service';
describe('SettlementtypeMasterService', function () {
    beforeEach(function () { return TestBed.configureTestingModule({}); });
    it('should be created', function () {
        var service = TestBed.get(SettlementtypeMasterService);
        expect(service).toBeTruthy();
    });
});
