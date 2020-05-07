import { TestBed } from '@angular/core/testing';
import { BusinessSegmentService } from './business-segment.service';
describe('BusinessSegmentService', function () {
    beforeEach(function () { return TestBed.configureTestingModule({}); });
    it('should be created', function () {
        var service = TestBed.get(BusinessSegmentService);
        expect(service).toBeTruthy();
    });
});
