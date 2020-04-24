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
import { HolidayMasterComponent } from './master/holiday-master/holiday-master.component'; 
//import { NgbModule, ModalDismissReasons } from '@ng-bootstrap/ng-bootstrap';
import { HolidayMasterService } from './Services/holiday-master.service'; 
import { LoginServiceService } from './Services/login-service.service'; 

import { HttpClientModule, HttpClient } from '@angular/common/http';


//import { MatRadioModule } from '@angular/material/radio';
//import { MatButtonModule } from '@angular/material/button';
//import { MatMenuModule } from '@angular/material/menu';

//import { MatDatepickerModule } from '@angular/material/datepicker';
//import { MatIconModule } from '@angular/material/icon';
//import { MatCardModule } from '@angular/material/card';


//import { MatSidenavModule } from '@angular/material/sidenav';

//import { MatTooltipModule } from '@angular/material/tooltip';

//import { MatInputModule } from '@angular/material/input';

//import { MatToolbarModule } from '@angular/material/toolbar';

//import { MatNativeDateModule } from '@angular/material';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
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
@NgModule({
    declarations: [
        AppComponent
        , LoginComponent
        , RegionMasterComponent
        , EmployeeMasterComponent
        , DesignationMasterComponent
        , HeaderComponent, FooterComponent, SidebarComponent, UserComponent, DashboardComponent, NachMandateComponent, HolidayMasterComponent
        , BranchMasterComponent, ChargeMasterComponent, DocumentMasterComponent, TemplateMasterComponent, SettlementTypeMasterComponent,
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
export class AppModule { }
export function getBaseUrl() {
    return document.getElementsByTagName('base')[0].href;
}
