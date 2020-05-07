import * as tslib_1 from "tslib";
import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
var ReturnRegionService = /** @class */ (function () {
    function ReturnRegionService(_http, myAppUrl) {
        this._http = _http;
        this.baseUrl = "";
        this.UserId = "";
        this.EntityId = "";
        this.baseUrl = myAppUrl;
        //    this.baseUrl = "http://localhost:49512/";
    }
    ReturnRegionService.prototype.getReturnRegions = function () {
        var item = JSON.parse(sessionStorage.getItem('User'));
        this.UserId = item.UserId;
        this.EntityId = item.ReferenceId;
        return this._http.get(this.baseUrl + 'api/ReturnRegionMaster/Index/' + this.UserId + '/' + this.EntityId);
    };
    ReturnRegionService.prototype.SaveReturnRegion = function (em) {
        var body = em;
        var headers = new HttpHeaders().set('content-type', 'application/json');
        var item = JSON.parse(sessionStorage.getItem('User'));
        this.UserId = item.UserId;
        this.EntityId = item.ReferenceId;
        return this._http.post(this.baseUrl + 'api/ReturnRegionMaster/Create/' + this.UserId + '/' + this.EntityId, body, {
            headers: headers
        });
    };
    //DeleteDocument(em): Observable<SettlementType> {
    //    return this._http.delete<SettlementType>(this.baseUrl + 'api/SettlementType/Delete/' + em);
    //}
    ReturnRegionService.prototype.UpdateReturnRegion = function (em, EmpId) {
        var body = em;
        var item = JSON.parse(sessionStorage.getItem('User'));
        this.UserId = item.UserId;
        this.EntityId = item.ReferenceId;
        var headers = new HttpHeaders().set('content-type', 'application/json');
        return this._http.post(this.baseUrl + 'api/ReturnRegionMaster/Edit/' + this.UserId + '/' + this.EntityId + '/' + EmpId, body, {
            headers: headers
        });
    };
    ReturnRegionService.prototype.errorHandler = function (error) {
        console.log(error);
        return Observable.throw(error);
    };
    ReturnRegionService = tslib_1.__decorate([
        Injectable({
            providedIn: 'root'
        }),
        tslib_1.__param(1, Inject('BASE_URL')),
        tslib_1.__metadata("design:paramtypes", [HttpClient, String])
    ], ReturnRegionService);
    return ReturnRegionService;
}());
export { ReturnRegionService };
