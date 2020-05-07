import { TestBed } from '@angular/core/testing';
import { ReturnRegionService } from './return-region.service';
describe('ReturnRegionService', function () {
    beforeEach(function () { return TestBed.configureTestingModule({}); });
    it('should be created', function () {
        var service = TestBed.get(ReturnRegionService);
        expect(service).toBeTruthy();
    });
});
