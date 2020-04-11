import { Injectable,Inject } from '@angular/core';
import { Router } from '@angular/router'; 
import { HttpClient,HttpHeaders,HttpParams,HttpResponse} from '@angular/common/http'; 
import { Observable } from 'rxjs';
import {map,catchError} from 'rxjs/operators';  
import { error } from 'util';

@Injectable({
  providedIn: 'root'
})
export class LoginServiceService {
    baseUrl: string = "";
    
    constructor(private _http: HttpClient, @Inject('BASE_URL') myAppUrl: string) {
        this.baseUrl = myAppUrl;
    }
 
    
errorHandler(error: Response) {  
  console.log(error);  
  return Observable.throw(error);  
}  

  }


