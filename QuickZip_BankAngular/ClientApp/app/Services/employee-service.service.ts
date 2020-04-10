import { Injectable,Inject } from '@angular/core';
import { Router } from '@angular/router'; 
import { HttpClient,HttpHeaders,HttpParams,HttpResponse} from '@angular/common/http'; 
import { Observable } from 'rxjs';
import {map,catchError} from 'rxjs/operators';  
import { error } from 'util';
import { Employee } from '../employee';



@Injectable({
  providedIn: 'root'
})
export class EmployeeServiceService {
    baseUrl: string = "";
    
    constructor(private _http: HttpClient, @Inject('BASE_URL') myAppUrl: string) {
        this.baseUrl = myAppUrl;
    }
 
    getEmployees(): Observable<any> {  
     
        return this._http.get<any>(this.baseUrl + 'api/Employee/Index');
    }  
    SaveEmployee(em:any): Observable<Employee> {
        const body = em;
        const headers = new HttpHeaders().set('content-type', 'application/json');
        return this._http.post<Employee>(this.baseUrl +'api/Employee/Create', body, {
            headers
        });
    }

    deleteItem(em): Observable<Employee> {
        return this._http.delete<Employee>(this.baseUrl + 'api/Employee/Delete/' + em);
    }

    updateItem(em: any,Userid): Observable<Employee> {
        const body = em;
        const headers = new HttpHeaders().set('content-type', 'application/json');
        return this._http.post<Employee>(this.baseUrl + 'api/Employee/Edit/'+Userid, body, {
            headers
        });
    }


errorHandler(error: Response) {  
  console.log(error);  
  return Observable.throw(error);  
}  

  }


