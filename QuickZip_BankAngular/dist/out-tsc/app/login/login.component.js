import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Validators, FormBuilder } from '@angular/forms';
var LoginComponent = /** @class */ (function () {
    function LoginComponent(router, formBuilder) {
        this.router = router;
        this.formBuilder = formBuilder;
    }
    LoginComponent.prototype.ngOnInit = function () {
        debugger;
        this.href1 = this.router.url;
        this.LoginForm = this.formBuilder.group({
            UserName: ['', Validators.required],
            Password: ['', Validators.required]
        });
    };
    LoginComponent.prototype.onSubmit = function () {
        this.router.navigate(['/dashboard']);
        //debugger;
        //alert('login click');
    };
    LoginComponent = tslib_1.__decorate([
        Component({
            selector: 'app-login',
            templateUrl: './login.component.html',
            styleUrls: ['./login.component.css']
        }),
        tslib_1.__metadata("design:paramtypes", [Router, FormBuilder])
    ], LoginComponent);
    return LoginComponent;
}());
export { LoginComponent };
