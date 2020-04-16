/// <reference path="master/employee-master/employee-master.component.spec.ts" />
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import {HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { UserComponent } from './master/user/user.component';
import { DashboardComponent } from './master/dashboard/dashboard.component';
import { NachMandateComponent } from './master/nach-mandate/nach-mandate.component';
import { HistoricalMandateComponent } from './master/historical-mandate/historical-mandate.component';
import { HolidayMasterComponent } from './master/holiday-master/holiday-master.component'; 

import { HolidayMasterService } from './Services/holiday-master.service'; 
import { LoginServiceService } from './Services/login-service.service'; 

import { HttpClientModule, HttpClient } from '@angular/common/http';


import { MatRadioModule } from '@angular/material/radio';
import { MatButtonModule } from '@angular/material/button';
import { MatMenuModule } from '@angular/material/menu';

import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatIconModule } from '@angular/material/icon';
import { MatCardModule } from '@angular/material/card';


import { MatSidenavModule } from '@angular/material/sidenav';

import { MatTooltipModule } from '@angular/material/tooltip';

import { MatInputModule } from '@angular/material/input';

import { MatToolbarModule } from '@angular/material/toolbar';

import { MatNativeDateModule } from '@angular/material';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CommonModule } from '@angular/common';
//import { NgMultiSelectDropDownModule } from 'ng-multiselect-dropdown';
import { RegionMasterComponent } from './master/region-master/region-master.component';
import { EmployeeMasterComponent } from './master/employee-master/employee-master.component';
import { DesignationMasterComponent } from './master/designation-master/designation-master.component';
@NgModule({
    declarations: [
        AppComponent
        , LoginComponent
        , RegionMasterComponent
        , EmployeeMasterComponent
        , DesignationMasterComponent
        , HeaderComponent, FooterComponent, SidebarComponent, UserComponent, DashboardComponent, NachMandateComponent, HistoricalMandateComponent, HolidayMasterComponent
    ],
    imports: [
        BrowserModule,
        AppRoutingModule,
        FormsModule,
        ReactiveFormsModule,
        CommonModule,
        HttpClientModule
    ],
    providers: [LoginServiceService, { provide: 'BASE_URL', useFactory: getBaseUrl }],

    bootstrap: [AppComponent]  
})
export class AppModule { }
export function getBaseUrl() {
    return document.getElementsByTagName('base')[0].href;
}
