import * as tslib_1 from "tslib";
import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
var DesignationMasterService = /** @class */ (function () {
    function DesignationMasterService(_http, myAppUrl) {
        this._http = _http;
        this.baseUrl = "";
        this.baseUrl = myAppUrl;
        //    this.baseUrl = "http://localhost:49512/";
    }
    DesignationMasterService.prototype.getDesignations = function () {
        return this._http.get(this.baseUrl + 'api/Designation/Index');
    };
    DesignationMasterService.prototype.SaveDesignation = function (em) {
        var body = em;
        var headers = new HttpHeaders().set('content-type', 'application/json');
        return this._http.post(this.baseUrl + 'api/Designation/Create', body, {
            headers: headers
        });
    };
    DesignationMasterService.prototype.DeleteDesignation = function (em) {
        return this._http.delete(this.baseUrl + 'api/Designation/Delete/' + em);
    };
    DesignationMasterService.prototype.UpdateDesignation = function (em, Userid) {
        var body = em;
        var headers = new HttpHeaders().set('content-type', 'application/json');
        return this._http.post(this.baseUrl + 'api/Designation/Edit/' + Userid, body, {
            headers: headers
        });
    };
    DesignationMasterService.prototype.errorHandler = function (error) {
        console.log(error);
        return Observable.throw(error);
    };
    DesignationMasterService = tslib_1.__decorate([
        Injectable({
            providedIn: 'root'
        }),
        tslib_1.__param(1, Inject('BASE_URL')),
        tslib_1.__metadata("design:paramtypes", [HttpClient, String])
    ], DesignationMasterService);
    return DesignationMasterService;
}());
export { DesignationMasterService };
