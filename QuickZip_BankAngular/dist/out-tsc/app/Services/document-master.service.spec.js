import { TestBed } from '@angular/core/testing';
import { DocumentMasterService } from './document-master.service';
describe('DocumentMasterService', function () {
    beforeEach(function () { return TestBed.configureTestingModule({}); });
    it('should be created', function () {
        var service = TestBed.get(DocumentMasterService);
        expect(service).toBeTruthy();
    });
});
