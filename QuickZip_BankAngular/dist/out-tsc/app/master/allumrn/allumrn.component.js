import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
var AllumrnComponent = /** @class */ (function () {
    function AllumrnComponent() {
    }
    AllumrnComponent.prototype.onClick = function (event) {
        this.showModal = true;
    };
    AllumrnComponent.prototype.onClick1 = function (event) {
        this.showModal1 = true;
    };
    AllumrnComponent.prototype.hide = function () {
        this.showModal = false;
        this.showModal1 = false;
    };
    AllumrnComponent.prototype.ngOnInit = function () {
    };
    AllumrnComponent = tslib_1.__decorate([
        Component({
            selector: 'app-allumrn',
            templateUrl: './allumrn.component.html',
            styleUrls: ['./allumrn.component.css']
        })
    ], AllumrnComponent);
    return AllumrnComponent;
}());
export { AllumrnComponent };
