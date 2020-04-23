import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Holiday } from 'ClientApp/app/Models/Holiday/holiday';
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
        //    this.baseUrl = "http://localhost:49512/";
    }

    getHolidays(): Observable<any> {
      
        return this._http.get<any>(this.baseUrl + 'api/Holiday/Index');
    }
    SaveHoliday(em: any): Observable<Holiday> {
        const body = em;
        const headers = new HttpHeaders().set('content-type', 'application/json');
        return this._http.post<Holiday>(this.baseUrl + 'api/Holiday/Create', body, {
            headers
        });
    }

    DeleteHoliday(em): Observable<Holiday> {
        return this._http.delete<Holiday>(this.baseUrl + 'api/Holiday/Delete/' + em);
    }

    UpdateHoliday(em: any, Userid): Observable<Holiday> {
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


