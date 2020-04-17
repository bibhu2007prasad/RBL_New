import * as tslib_1 from "tslib";
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './login/login.component';
import { HeaderComponent } from './header/header.component';
import { FooterComponent } from './footer/footer.component';
import { SidebarComponent } from './sidebar/sidebar.component';
import { UserComponent } from './master/user/user.component';
import { DashboardComponent } from './master/dashboard/dashboard.component';
import { NachMandateComponent } from './master/nach-mandate/nach-mandate.component';
import { HolidayMasterComponent } from './master/holiday-master/holiday-master.component';
import { LoginServiceService } from './Services/login-service.service';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';
//import { NgMultiSelectDropDownModule } from 'ng-multiselect-dropdown';
import { RegionMasterComponent } from './master/region-master/region-master.component';
import { EmployeeMasterComponent } from './master/employee-master/employee-master.component';
import { DesignationMasterComponent } from './master/designation-master/designation-master.component';
import { AllumrnComponent } from './master/allumrn/allumrn.component';
import { NewhistoricalmandateComponent } from './master/newhistoricalmandate/newhistoricalmandate.component';
import { EntityComponent } from './master/entity/entity.component';
import { CommunicationtemplateComponent } from './master/communicationtemplate/communicationtemplate.component';
import { SubmembermasterComponent } from './master/submembermaster/submembermaster.component';
import { UtilitymasterComponent } from './master/utilitymaster/utilitymaster.component';
import { BranchmasterComponent } from './master/branchmaster/branchmaster.component';
import { PsmmasterComponent } from './master/psmmaster/psmmaster.component';
import { CorporatesetupComponent } from './master/corporatesetup/corporatesetup.component';
import { SubmemberbanksetupComponent } from './master/submemberbanksetup/submemberbanksetup.component';
import { UserrolesetupComponent } from './master/userrolesetup/userrolesetup.component';
import { DebitpresentmentsetupComponent } from './master/debitpresentmentsetup/debitpresentmentsetup.component';
import { UsersetupComponent } from './master/usersetup/usersetup.component';
var AppModule = /** @class */ (function () {
    function AppModule() {
    }
    AppModule = tslib_1.__decorate([
        NgModule({
            declarations: [
                AppComponent,
                LoginComponent,
                RegionMasterComponent,
                EmployeeMasterComponent,
                DesignationMasterComponent,
                HeaderComponent, FooterComponent, SidebarComponent, UserComponent, DashboardComponent, NachMandateComponent, HolidayMasterComponent, AllumrnComponent, NewhistoricalmandateComponent, EntityComponent, CommunicationtemplateComponent, SubmembermasterComponent, UtilitymasterComponent, BranchmasterComponent, PsmmasterComponent, CorporatesetupComponent, SubmemberbanksetupComponent, UserrolesetupComponent, DebitpresentmentsetupComponent, UsersetupComponent
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
    ], AppModule);
    return AppModule;
}());
export { AppModule };
export function getBaseUrl() {
    return document.getElementsByTagName('base')[0].href;
}
