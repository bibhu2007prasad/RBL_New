import * as tslib_1 from "tslib";
import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
var LoginServiceService = /** @class */ (function () {
    function LoginServiceService(_http, myAppUrl) {
        this._http = _http;
        this.baseUrl = "";
        this.baseUrl = myAppUrl;
    }
    LoginServiceService.prototype.GetLogin = function (Username, Password) {
        return this._http.get(this.baseUrl + 'api/Login/getlogindetails/' + Username + '/' + Password);
    };
    LoginServiceService.prototype.errorHandler = function (error) {
        console.log(error);
        return Observable.throw(error);
    };
    LoginServiceService = tslib_1.__decorate([
        Injectable({
            providedIn: 'root'
        }),
        tslib_1.__param(1, Inject('BASE_URL')),
        tslib_1.__metadata("design:paramtypes", [HttpClient, String])
    ], LoginServiceService);
    return LoginServiceService;
}());
export { LoginServiceService };
