import { TestBed } from '@angular/core/testing';
import { RegionMasterService } from './region-master.service';
describe('RegionMasterService', function () {
    beforeEach(function () { return TestBed.configureTestingModule({}); });
    it('should be created', function () {
        var service = TestBed.get(RegionMasterService);
        expect(service).toBeTruthy();
    });
});
