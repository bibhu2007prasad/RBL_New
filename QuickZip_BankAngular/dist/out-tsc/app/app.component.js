import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
import { Router } from '@angular/router';
var AppComponent = /** @class */ (function () {
    function AppComponent(router1) {
        this.router1 = router1;
        this.title = 'Login';
    }
    AppComponent.prototype.ngOnInit = function () {
        this.href1 = this.router1.url;
    };
    AppComponent = tslib_1.__decorate([
        Component({
            selector: 'app-root',
            templateUrl: './app.component.html',
            styleUrls: ['./app.component.css']
        }),
        tslib_1.__metadata("design:paramtypes", [Router])
    ], AppComponent);
    return AppComponent;
}());
export { AppComponent };
