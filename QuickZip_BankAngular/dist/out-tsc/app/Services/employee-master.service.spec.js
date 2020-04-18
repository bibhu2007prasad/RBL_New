import { TestBed } from '@angular/core/testing';
import { EmployeeMasterService } from './employee-master.service';
describe('EmployeeMasterService', function () {
    beforeEach(function () { return TestBed.configureTestingModule({}); });
    it('should be created', function () {
        var service = TestBed.get(EmployeeMasterService);
        expect(service).toBeTruthy();
    });
});
