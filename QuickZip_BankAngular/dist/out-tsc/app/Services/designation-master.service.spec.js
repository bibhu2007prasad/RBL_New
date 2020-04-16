import { TestBed } from '@angular/core/testing';
import { DesignationMasterService } from './designation-master.service';
describe('DesignationMasterService', function () {
    beforeEach(function () { return TestBed.configureTestingModule({}); });
    it('should be created', function () {
        var service = TestBed.get(DesignationMasterService);
        expect(service).toBeTruthy();
    });
});
