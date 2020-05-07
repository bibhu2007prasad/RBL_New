import * as tslib_1 from "tslib";
import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
var SettlementtypeMasterService = /** @class */ (function () {
    function SettlementtypeMasterService(_http, myAppUrl) {
        this._http = _http;
        this.baseUrl = "";
        this.UserId = "";
        this.EntityId = "";
        this.baseUrl = myAppUrl;
        //    this.baseUrl = "http://localhost:49512/";
    }
    SettlementtypeMasterService.prototype.getSettlementTypes = function () {
        var item = JSON.parse(sessionStorage.getItem('User'));
        this.UserId = item.UserId;
        this.EntityId = item.ReferenceId;
        return this._http.get(this.baseUrl + 'api/SettlementType/Index/' + this.UserId + '/' + this.EntityId);
    };
    SettlementtypeMasterService.prototype.SaveSettlementType = function (em) {
        var body = em;
        var headers = new HttpHeaders().set('content-type', 'application/json');
        var item = JSON.parse(sessionStorage.getItem('User'));
        this.UserId = item.UserId;
        this.EntityId = item.ReferenceId;
        return this._http.post(this.baseUrl + 'api/SettlementType/Create/' + this.UserId + '/' + this.EntityId, body, {
            headers: headers
        });
    };
    //DeleteDocument(em): Observable<SettlementType> {
    //    return this._http.delete<SettlementType>(this.baseUrl + 'api/SettlementType/Delete/' + em);
    //}
    SettlementtypeMasterService.prototype.UpdateSettlementType = function (em, EmpId) {
        var body = em;
        var item = JSON.parse(sessionStorage.getItem('User'));
        this.UserId = item.UserId;
        this.EntityId = item.ReferenceId;
        var headers = new HttpHeaders().set('content-type', 'application/json');
        return this._http.post(this.baseUrl + 'api/SettlementType/Edit/' + this.UserId + '/' + this.EntityId + '/' + EmpId, body, {
            headers: headers
        });
    };
    SettlementtypeMasterService.prototype.errorHandler = function (error) {
        console.log(error);
        return Observable.throw(error);
    };
    SettlementtypeMasterService = tslib_1.__decorate([
        Injectable({
            providedIn: 'root'
        }),
        tslib_1.__param(1, Inject('BASE_URL')),
        tslib_1.__metadata("design:paramtypes", [HttpClient, String])
    ], SettlementtypeMasterService);
    return SettlementtypeMasterService;
}());
export { SettlementtypeMasterService };
