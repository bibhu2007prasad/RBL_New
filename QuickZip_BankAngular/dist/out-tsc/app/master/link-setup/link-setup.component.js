import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
var LinkSetupComponent = /** @class */ (function () {
    function LinkSetupComponent() {
    }
    LinkSetupComponent.prototype.onClick = function (event) {
        this.showModal = true;
    };
    LinkSetupComponent.prototype.hide = function () {
        this.showModal = false;
    };
    LinkSetupComponent.prototype.ngOnInit = function () {
    };
    LinkSetupComponent = tslib_1.__decorate([
        Component({
            selector: 'app-link-setup',
            templateUrl: './link-setup.component.html',
            styleUrls: ['./link-setup.component.css']
        }),
        tslib_1.__metadata("design:paramtypes", [])
    ], LinkSetupComponent);
    return LinkSetupComponent;
}());
export { LinkSetupComponent };
