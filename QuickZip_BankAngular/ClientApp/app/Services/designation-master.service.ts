import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders, HttpParams, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Designation } from 'ClientApp/app/Models/Designation/designation';
import { Router } from '@angular/router';
import { map, catchError } from 'rxjs/operators';
import { error } from 'util';

@Injectable({
  providedIn: 'root'
})
export class DesignationMasterService {

    baseUrl: string = "";
    constructor(private _http: HttpClient, @Inject('BASE_URL') myAppUrl: string) {
        this.baseUrl = myAppUrl;
    }

    getDesignations(): Observable<any> {
        debugger;

        return this._http.get<any>(this.baseUrl + 'api/Designation/Index');
    }
    SaveDesignation(em: any): Observable<Designation> {
        const body = em;
        const headers = new HttpHeaders().set('content-type', 'application/json');
        return this._http.post<Designation>(this.baseUrl + 'api/Designation/Create', body, {
            headers
        });
    }

    DeleteDesignation(em): Observable<Designation> {
        return this._http.delete<Designation>(this.baseUrl + 'api/Designation/Delete/' + em);
    }

    UpdateDesignation(em: any, Userid): Observable<Designation> {
        const body = em;
        const headers = new HttpHeaders().set('content-type', 'application/json');
        return this._http.post<Designation>(this.baseUrl + 'api/Designation/Edit/' + Userid, body, {
            headers
        });
    }


    errorHandler(error: Response) {
        console.log(error);
        return Observable.throw(error);
    }

}


