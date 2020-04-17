import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { UserComponent } from './master/user/user.component';
import { DashboardComponent } from './master/dashboard/dashboard.component';
import { NachMandateComponent } from './master/nach-mandate/nach-mandate.component';
import { HolidayMasterComponent } from './master/holiday-master/holiday-master.component';
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




const routes: Routes = [{ path: '', redirectTo: '', component: LoginComponent, pathMatch: 'full' },
    { path: 'Login', component: LoginComponent },
    { path: 'user', component: UserComponent },    
    { path: 'dashboard', component: DashboardComponent },
    { path: 'NachMandate', component: NachMandateComponent },
    { path: 'HolidayMaster', component: HolidayMasterComponent },
    { path: 'RegionMaster', component: RegionMasterComponent },
    { path: 'EmployeeMaster', component: EmployeeMasterComponent },
    { path: 'DesignationMaster', component: DesignationMasterComponent },
    { path: 'Allumrn', component: AllumrnComponent },
    { path: 'Newhistoricalmandate', component: NewhistoricalmandateComponent },
    { path: 'Entity', component: EntityComponent },
    { path: 'Communicationtemplate', component: CommunicationtemplateComponent },    
    { path: 'Submembermaster', component: SubmembermasterComponent },    
    { path: 'Utilitymaster', component: UtilitymasterComponent },    
    { path: 'Branchmaster', component: BranchmasterComponent },    
    { path: 'Psmmaster', component: PsmmasterComponent },

    { path: 'Corporatesetup', component: CorporatesetupComponent },
    { path: 'Submemberbanksetup', component: SubmemberbanksetupComponent },
    { path: 'Userrolesetup', component: UserrolesetupComponent },
    { path: 'Debitpresentmentsetup', component: DebitpresentmentsetupComponent },
    { path: 'Usersetup', component: UsersetupComponent }

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
