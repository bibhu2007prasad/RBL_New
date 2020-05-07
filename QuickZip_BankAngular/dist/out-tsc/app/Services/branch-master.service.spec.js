import { TestBed } from '@angular/core/testing';
import { BranchMasterService } from './branch-master.service';
describe('BranchMasterService', function () {
    beforeEach(function () { return TestBed.configureTestingModule({}); });
    it('should be created', function () {
        var service = TestBed.get(BranchMasterService);
        expect(service).toBeTruthy();
    });
});
