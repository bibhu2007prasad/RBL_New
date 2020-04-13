import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { UserComponent } from './master/user/user.component';
import { DashboardComponent } from './master/dashboard/dashboard.component';
import { NachMandateComponent } from './master/nach-mandate/nach-mandate.component';
import { HistoricalMandateComponent } from './master/historical-mandate/historical-mandate.component';
import { HolidayMasterComponent } from './master/holiday-master/holiday-master.component';

const routes: Routes = [{ path: '', redirectTo: '', component: LoginComponent, pathMatch: 'full' },
    { path: 'Login', component: LoginComponent },
    { path: 'user', component: UserComponent },    
    { path: 'dashboard', component: DashboardComponent },
    { path: 'NachMandate', component: NachMandateComponent },
    { path: 'HistoricalMandate', component: HistoricalMandateComponent },
    { path: 'HolidayMaster',  component:  HolidayMasterComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
