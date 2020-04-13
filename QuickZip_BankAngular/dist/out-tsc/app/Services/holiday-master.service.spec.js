import { TestBed } from '@angular/core/testing';
import { HolidayMasterService } from './holiday-master.service';
describe('HolidayMasterService', function () {
    beforeEach(function () { return TestBed.configureTestingModule({}); });
    it('should be created', function () {
        var service = TestBed.get(HolidayMasterService);
        expect(service).toBeTruthy();
    });
});
