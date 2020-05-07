import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { UserComponent } from './master/user/user.component';
import { DashboardComponent } from './master/dashboard/dashboard.component';
import { NachMandateComponent } from './master/nach-mandate/nach-mandate.component';
import { HistoricalMandateComponent } from './master/historical-mandate/historical-mandate.component';
import { HolidayMasterComponent } from './master/holiday-master/holiday-master.component';
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

const routes: Routes = [{ path: '', redirectTo: '', component: LoginComponent, pathMatch: 'full' },
    { path: 'Login', component: LoginComponent },
    { path: 'user', component: UserComponent },    
    { path: 'dashboard', component: DashboardComponent },
    { path: 'NachMandate', component: NachMandateComponent },
    { path: 'HistoricalMandate', component: HistoricalMandateComponent },
    { path: 'HolidayMaster', component: HolidayMasterComponent },
    { path: 'RegionMaster', component: RegionMasterComponent },
    { path: 'EmployeeMaster', component: EmployeeMasterComponent },
    { path: 'DesignationMaster', component: DesignationMasterComponent },
    { path: 'BranchMaster', component: BranchMasterComponent },
    { path: 'ChargeMaster', component: ChargeMasterComponent },
    { path: 'DocumentMaster', component: DocumentMasterComponent },
    { path: 'TemplateMaster', component: TemplateMasterComponent },
    { path: 'SettlementTypeMaster', component: SettlementTypeMasterComponent },
    { path: 'BusinessSegmentMaster', component: BusinessSegmentMasterComponent },
    { path: 'ReturnReasonMaster', component: ReturnReasonMasterComponent },
    { path: 'Allumrn', component: AllumrnComponent },
    { path: 'Newhistoricalmandate', component: NewhistoricalmandateComponent },
    { path: 'Communicationtemplate', component: CommunicationtemplateComponent },
    { path: 'Submembermaster', component: SubmembermasterComponent },
    { path: 'Utilitymaster', component: UtilitymasterComponent },
    { path: 'Psmmaster', component: PsmmasterComponent },
    { path: 'RBLBranchmaster', component: RblBranchMasterComponent },
    { path: 'Corporatesetup', component: CorporatesetupComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
