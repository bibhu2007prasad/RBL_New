import { TestBed } from '@angular/core/testing';
import { EmployeeServiceService } from './employee-service.service';
describe('EmployeeServiceService', function () {
    beforeEach(function () { return TestBed.configureTestingModule({}); });
    it('should be created', function () {
        var service = TestBed.get(EmployeeServiceService);
        expect(service).toBeTruthy();
    });
});
