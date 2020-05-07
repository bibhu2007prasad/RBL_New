import * as tslib_1 from "tslib";
import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
var RegionMasterService = /** @class */ (function () {
    function RegionMasterService(_http, myAppUrl) {
        this._http = _http;
        this.baseUrl = "";
        this.UserId = "";
        this.EntityId = "";
        this.baseUrl = myAppUrl;
        //    this.baseUrl = "http://localhost:49512/";
    }
    RegionMasterService.prototype.BindStates = function () {
        var item = JSON.parse(sessionStorage.getItem('User'));
        this.UserId = item.UserId;
        this.EntityId = item.ReferenceId;
        return this._http.get(this.baseUrl + 'api/RegionMaster/BindStates/' + this.UserId + '/' + this.EntityId);
    };
    RegionMasterService.prototype.getRegionMasters = function () {
        var item = JSON.parse(sessionStorage.getItem('User'));
        this.UserId = item.UserId;
        this.EntityId = item.ReferenceId;
        return this._http.get(this.baseUrl + 'api/RegionMaster/Index/' + this.UserId + '/' + this.EntityId);
    };
    RegionMasterService.prototype.SaveRegionMaster = function (em) {
        var body = em;
        var headers = new HttpHeaders().set('content-type', 'application/json');
        var item = JSON.parse(sessionStorage.getItem('User'));
        this.UserId = item.UserId;
        this.EntityId = item.ReferenceId;
        return this._http.post(this.baseUrl + 'api/RegionMaster/Create/' + this.UserId + '/' + this.EntityId, body, {
            headers: headers
        });
    };
    //DeleteDocument(em): Observable<RegionMaster> {
    //    return this._http.delete<RegionMaster>(this.baseUrl + 'api/RegionMaster/Delete/' + em);
    //}
    RegionMasterService.prototype.UpdateRegionMaster = function (em, BranchId) {
        var body = em;
        var item = JSON.parse(sessionStorage.getItem('User'));
        this.UserId = item.UserId;
        this.EntityId = item.ReferenceId;
        var headers = new HttpHeaders().set('content-type', 'application/json');
        return this._http.post(this.baseUrl + 'api/RegionMaster/Edit/' + this.UserId + '/' + this.EntityId + '/' + BranchId, body, {
            headers: headers
        });
    };
    RegionMasterService.prototype.errorHandler = function (error) {
        console.log(error);
        return Observable.throw(error);
    };
    RegionMasterService = tslib_1.__decorate([
        Injectable({
            providedIn: 'root'
        }),
        tslib_1.__param(1, Inject('BASE_URL')),
        tslib_1.__metadata("design:paramtypes", [HttpClient, String])
    ], RegionMasterService);
    return RegionMasterService;
}());
export { RegionMasterService };
