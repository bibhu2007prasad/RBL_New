import * as tslib_1 from "tslib";
import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
//After that we write all methods related to consume web in employee.service.ts  
var HolidayMasterService = /** @class */ (function () {
    function HolidayMasterService(_http, myAppUrl) {
        this._http = _http;
        this.baseUrl = "";
        this.baseUrl = myAppUrl;
    }
    HolidayMasterService.prototype.getHolidays = function () {
        return this._http.get(this.baseUrl + 'api/Holiday/Index');
    };
    HolidayMasterService.prototype.SaveHoliday = function (em) {
        var body = em;
        var headers = new HttpHeaders().set('content-type', 'application/json');
        return this._http.post(this.baseUrl + 'api/Holiday/Create', body, {
            headers: headers
        });
    };
    HolidayMasterService.prototype.DeleteHoliday = function (em) {
        return this._http.delete(this.baseUrl + 'api/Holiday/Delete/' + em);
    };
    HolidayMasterService.prototype.UpdateHoliday = function (em, Userid) {
        var body = em;
        var headers = new HttpHeaders().set('content-type', 'application/json');
        return this._http.post(this.baseUrl + 'api/Holiday/Edit/' + Userid, body, {
            headers: headers
        });
    };
    HolidayMasterService.prototype.errorHandler = function (error) {
        console.log(error);
        return Observable.throw(error);
    };
    HolidayMasterService = tslib_1.__decorate([
        Injectable({
            providedIn: 'root'
        }),
        tslib_1.__param(1, Inject('BASE_URL')),
        tslib_1.__metadata("design:paramtypes", [HttpClient, String])
    ], HolidayMasterService);
    return HolidayMasterService;
}());
export { HolidayMasterService };
