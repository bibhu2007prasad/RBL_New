import * as tslib_1 from "tslib";
/// <reference path="master/employee-master/employee-master.component.spec.ts" />
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
import { BranchMasterComponent } from './master/branch-master/branch-master.component';
import { ChargeMasterComponent } from './master/charge-master/charge-master.component';
import { DocumentMasterComponent } from './master/document-master/document-master.component';
import { TemplateMasterComponent } from './master/template-master/template-master.component';
import { SettlementTypeMasterComponent } from './master/settlement-type-master/settlement-type-master.component';
import { BusinessSegmentMasterComponent } from './master/business-segment-master/business-segment-master.component';
import { ReturnReasonMasterComponent } from './master/return-reason-master/return-reason-master.component';
import { AllumrnComponent } from './master/allumrn/allumrn.component';
import { NewhistoricalmandateComponent } from './master/newhistoricalmandate/newhistoricalmandate.component';
import { CommunicationtemplateComponent } from './master/communicationtemplate/communicationtemplate.component';
import { SubmembermasterComponent } from './master/submembermaster/submembermaster.component';
import { UtilitymasterComponent } from './master/utilitymaster/utilitymaster.component';
import { PsmmasterComponent } from './master/psmmaster/psmmaster.component';
import { RblBranchMasterComponent } from './master/rbl-branch-master/rbl-branch-master.component';
import { CorporatesetupComponent } from './master/corporatesetup/corporatesetup.component';
import { LinkSetupComponent } from './master/link-setup/link-setup.component';
//import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
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
                HeaderComponent, FooterComponent, SidebarComponent, UserComponent, DashboardComponent, NachMandateComponent, HolidayMasterComponent,
                BranchMasterComponent, ChargeMasterComponent, DocumentMasterComponent, TemplateMasterComponent, SettlementTypeMasterComponent,
                BusinessSegmentMasterComponent, ReturnReasonMasterComponent, AllumrnComponent, NewhistoricalmandateComponent, CommunicationtemplateComponent, SubmembermasterComponent, UtilitymasterComponent, PsmmasterComponent, RblBranchMasterComponent, CorporatesetupComponent, LinkSetupComponent
            ],
            imports: [
                BrowserModule,
                AppRoutingModule,
                FormsModule,
                ReactiveFormsModule,
                CommonModule,
                HttpClientModule,
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
