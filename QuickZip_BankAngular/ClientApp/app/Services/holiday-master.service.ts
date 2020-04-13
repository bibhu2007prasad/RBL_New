import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Holiday } from 'ClientApp/app/Models/holiday';
import { Router } from '@angular/router';
import { map, catchError } from 'rxjs/operators';
import { error } from 'util';

//After that we write all methods related to consume web in employee.service.ts  
@Injectable({
    providedIn: 'root'
})

export class HolidayMasterService {

    baseUrl: string = "";

    constructor(private _http: HttpClient, @Inject('BASE_URL') myAppUrl: string) {
        this.baseUrl = myAppUrl;
    }

    getAllHoliday(): Observable<any> {
        debugger;

        return this._http.get<any>(this.baseUrl + 'api/Holiday/Index');
    }
    SaveEmployee(em: any): Observable<Holiday> {
        const body = em;
        const headers = new HttpHeaders().set('content-type', 'application/json');
        return this._http.post<Holiday>(this.baseUrl + 'api/Holiday/Create', body, {
            headers
        });
    }

    deleteItem(em): Observable<Holiday> {
        return this._http.delete<Holiday>(this.baseUrl + 'api/Holiday/Delete/' + em);
    }

    updateItem(em: any, Userid): Observable<Holiday> {
        const body = em;
        const headers = new HttpHeaders().set('content-type', 'application/json');
        return this._http.post<Holiday>(this.baseUrl + 'api/Holiday/Edit/' + Userid, body, {
            headers
        });
    }


    errorHandler(error: Response) {
        console.log(error);
        return Observable.throw(error);
    }

}







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