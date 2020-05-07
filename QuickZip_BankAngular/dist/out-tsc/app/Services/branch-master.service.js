import * as tslib_1 from "tslib";
import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
var BranchMasterService = /** @class */ (function () {
    function BranchMasterService(_http, myAppUrl) {
        this._http = _http;
        this.baseUrl = "";
        this.UserId = "";
        this.EntityId = "";
        this.baseUrl = myAppUrl;
        //    this.baseUrl = "http://localhost:49512/";
    }
    BranchMasterService.prototype.BindStates = function () {
        var item = JSON.parse(sessionStorage.getItem('User'));
        this.UserId = item.UserId;
        this.EntityId = item.ReferenceId;
        return this._http.get(this.baseUrl + 'api/BranchMaster/BindStates/' + this.UserId + '/' + this.EntityId);
    };
    BranchMasterService.prototype.getBranchMasters = function () {
        var item = JSON.parse(sessionStorage.getItem('User'));
        this.UserId = item.UserId;
        this.EntityId = item.ReferenceId;
        return this._http.get(this.baseUrl + 'api/BranchMaster/Index/' + this.UserId + '/' + this.EntityId);
    };
    BranchMasterService.prototype.SaveBranchMaster = function (em) {
        var body = em;
        var headers = new HttpHeaders().set('content-type', 'application/json');
        var item = JSON.parse(sessionStorage.getItem('User'));
        this.UserId = item.UserId;
        this.EntityId = item.ReferenceId;
        return this._http.post(this.baseUrl + 'api/BranchMaster/Create/' + this.UserId + '/' + this.EntityId, body, {
            headers: headers
        });
    };
    //DeleteDocument(em): Observable<BranchMaster> {
    //    return this._http.delete<BranchMaster>(this.baseUrl + 'api/BranchMaster/Delete/' + em);
    //}
    BranchMasterService.prototype.UpdateBranchMaster = function (em, BranchId) {
        var body = em;
        var item = JSON.parse(sessionStorage.getItem('User'));
        this.UserId = item.UserId;
        this.EntityId = item.ReferenceId;
        var headers = new HttpHeaders().set('content-type', 'application/json');
        return this._http.post(this.baseUrl + 'api/BranchMaster/Edit/' + this.UserId + '/' + this.EntityId + '/' + BranchId, body, {
            headers: headers
        });
    };
    BranchMasterService.prototype.errorHandler = function (error) {
        console.log(error);
        return Observable.throw(error);
    };
    BranchMasterService = tslib_1.__decorate([
        Injectable({
            providedIn: 'root'
        }),
        tslib_1.__param(1, Inject('BASE_URL')),
        tslib_1.__metadata("design:paramtypes", [HttpClient, String])
    ], BranchMasterService);
    return BranchMasterService;
}());
export { BranchMasterService };
