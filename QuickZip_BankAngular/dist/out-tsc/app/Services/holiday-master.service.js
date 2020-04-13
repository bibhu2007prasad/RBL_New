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
    HolidayMasterService.prototype.getAllHoliday = function () {
        debugger;
        return this._http.get(this.baseUrl + 'api/Holiday/Index');
    };
    HolidayMasterService.prototype.SaveEmployee = function (em) {
        var body = em;
        var headers = new HttpHeaders().set('content-type', 'application/json');
        return this._http.post(this.baseUrl + 'api/Holiday/Create', body, {
            headers: headers
        });
    };
    HolidayMasterService.prototype.deleteItem = function (em) {
        return this._http.delete(this.baseUrl + 'api/Holiday/Delete/' + em);
    };
    HolidayMasterService.prototype.updateItem = function (em, Userid) {
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
//    url = 'http://localhost:49512/Api';
//    constructor(private http: HttpClient) { }
//    getAllHoliday(): Observable<Holiday[]> {
//        return this.http.get<Holiday[]>(this.url + '/AllHolidayDetails');
//    }
//    getHolidayById(employeeId: string): Observable<Holiday> {
//        return this.http.get<Holiday>(this.url + '/GetHolidayDetailsById/' + employeeId);
//    }
//    createHoliday(holiday: Holiday): Observable<Holiday> {
//        const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
//        return this.http.post<Holiday>(this.url + '/InsertHolidayDetails/',
//            holiday, httpOptions);
//    }
//    updateHoliday(holiday: Holiday): Observable<Holiday> {
//        const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
//        return this.http.put<Holiday>(this.url + '/UpdateHolidayDetails/',
//            holiday, httpOptions);
//    }
//    deleteHolidayById(holidayId: string): Observable<number> {
//        const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
//        return this.http.delete<number>(this.url + '/DeleteHolidayDetails?id=' + holidayId,
//            httpOptions);
//    }
//}  
