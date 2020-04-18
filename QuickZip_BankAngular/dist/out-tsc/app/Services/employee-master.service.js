import * as tslib_1 from "tslib";
import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
var EmployeeMasterService = /** @class */ (function () {
    function EmployeeMasterService(_http, myAppUrl) {
        this._http = _http;
        this.baseUrl = "";
        this.UserId = "";
        this.EntityId = "";
        this.baseUrl = myAppUrl;
    }
    EmployeeMasterService.prototype.BindDesignation = function () {
        var item = JSON.parse(sessionStorage.getItem('User'));
        this.UserId = item.UserId;
        this.EntityId = item.ReferenceId;
        return this._http.get(this.baseUrl + 'api/Employee/BindDesignation/' + this.UserId + '/' + this.EntityId);
    };
    EmployeeMasterService.prototype.getEmployees = function () {
        var item = JSON.parse(sessionStorage.getItem('User'));
        this.UserId = item.UserId;
        this.EntityId = item.ReferenceId;
        return this._http.get(this.baseUrl + 'api/Employee/Index/' + this.UserId + '/' + this.EntityId);
    };
    EmployeeMasterService.prototype.SaveEmployee = function (em) {
        var body = em;
        var headers = new HttpHeaders().set('content-type', 'application/json');
        var item = JSON.parse(sessionStorage.getItem('User'));
        this.UserId = item.UserId;
        this.EntityId = item.ReferenceId;
        return this._http.post(this.baseUrl + 'api/Employee/Create/' + this.UserId + '/' + this.EntityId, body, {
            headers: headers
        });
    };
    //DeleteDocument(em): Observable<Employee> {
    //    return this._http.delete<Employee>(this.baseUrl + 'api/Employee/Delete/' + em);
    //}
    EmployeeMasterService.prototype.UpdateEmployee = function (em, EmpId) {
        var body = em;
        var item = JSON.parse(sessionStorage.getItem('User'));
        this.UserId = item.UserId;
        this.EntityId = item.ReferenceId;
        var headers = new HttpHeaders().set('content-type', 'application/json');
        return this._http.post(this.baseUrl + 'api/Employee/Edit/' + this.UserId + '/' + this.EntityId + '/' + EmpId, body, {
            headers: headers
        });
    };
    EmployeeMasterService.prototype.errorHandler = function (error) {
        console.log(error);
        return Observable.throw(error);
    };
    EmployeeMasterService = tslib_1.__decorate([
        Injectable({
            providedIn: 'root'
        }),
        tslib_1.__param(1, Inject('BASE_URL')),
        tslib_1.__metadata("design:paramtypes", [HttpClient, String])
    ], EmployeeMasterService);
    return EmployeeMasterService;
}());
export { EmployeeMasterService };
