import * as tslib_1 from "tslib";
import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
var EmployeeServiceService = /** @class */ (function () {
    function EmployeeServiceService(_http, myAppUrl) {
        this._http = _http;
        this.baseUrl = "";
        this.baseUrl = myAppUrl;
    }
    EmployeeServiceService.prototype.getEmployees = function () {
        return this._http.get(this.baseUrl + 'api/Employee/Index');
    };
    EmployeeServiceService.prototype.SaveEmployee = function (em) {
        var body = em;
        var headers = new HttpHeaders().set('content-type', 'application/json');
        return this._http.post(this.baseUrl + 'api/Employee/Create', body, {
            headers: headers
        });
    };
    EmployeeServiceService.prototype.deleteItem = function (em) {
        return this._http.delete(this.baseUrl + 'api/Employee/Delete/' + em);
    };
    EmployeeServiceService.prototype.updateItem = function (em, Userid) {
        var body = em;
        var headers = new HttpHeaders().set('content-type', 'application/json');
        return this._http.post(this.baseUrl + 'api/Employee/Edit/' + Userid, body, {
            headers: headers
        });
    };
    EmployeeServiceService.prototype.errorHandler = function (error) {
        console.log(error);
        return Observable.throw(error);
    };
    EmployeeServiceService = tslib_1.__decorate([
        Injectable({
            providedIn: 'root'
        }),
        tslib_1.__param(1, Inject('BASE_URL')),
        tslib_1.__metadata("design:paramtypes", [HttpClient, String])
    ], EmployeeServiceService);
    return EmployeeServiceService;
}());
export { EmployeeServiceService };
