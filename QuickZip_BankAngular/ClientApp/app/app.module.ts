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
import { HolidayMasterComponent } from './master/holiday-master/holiday-master.component'; 
import { HolidayMasterService } from './Services/holiday-master.service'; 
import { LoginServiceService } from './Services/login-service.service'; 
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CommonModule } from '@angular/common';
//import { NgMultiSelectDropDownModule } from 'ng-multiselect-dropdown';
import { RegionMasterComponent } from './master/region-master/region-master.component';
import { EmployeeMasterComponent } from './master/employee-master/employee-master.component';
import { DesignationMasterComponent } from './master/designation-master/designation-master.component';
import { AllumrnComponent } from './master/allumrn/allumrn.component';
import { NewhistoricalmandateComponent } from './master/newhistoricalmandate/newhistoricalmandate.component';
@NgModule({
    declarations: [
        AppComponent
        , LoginComponent
        , RegionMasterComponent
        , EmployeeMasterComponent
        , DesignationMasterComponent
        , HeaderComponent, FooterComponent, SidebarComponent, UserComponent, DashboardComponent, NachMandateComponent, HolidayMasterComponent, AllumrnComponent, NewhistoricalmandateComponent
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
