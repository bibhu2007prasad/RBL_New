import { async, TestBed } from '@angular/core/testing';
import { CommunicationtemplateComponent } from './communicationtemplate.component';
describe('CommunicationtemplateComponent', function () {
    var component;
    var fixture;
    beforeEach(async(function () {
        TestBed.configureTestingModule({
            declarations: [CommunicationtemplateComponent]
        })
            .compileComponents();
    }));
    beforeEach(function () {
        fixture = TestBed.createComponent(CommunicationtemplateComponent);
        component = fixture.componentInstance;
        fixture.detectChanges();
    });
    it('should create', function () {
        expect(component).toBeTruthy();
    });
});
