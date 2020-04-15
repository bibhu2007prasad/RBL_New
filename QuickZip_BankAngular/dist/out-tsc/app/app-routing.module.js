import * as tslib_1 from "tslib";
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { UserComponent } from './master/user/user.component';
import { DashboardComponent } from './master/dashboard/dashboard.component';
import { NachMandateComponent } from './master/nach-mandate/nach-mandate.component';
import { HistoricalMandateComponent } from './master/historical-mandate/historical-mandate.component';
import { HolidayMasterComponent } from './master/holiday-master/holiday-master.component';
import { RegionMasterComponent } from './master/region-master/region-master.component';
import { EmployeeMasterComponent } from './master/employee-master/employee-master.component';
import { DesignationMasterComponent } from './master/designation-master/designation-master.component';
var routes = [{ path: '', redirectTo: '', component: LoginComponent, pathMatch: 'full' },
    { path: 'Login', component: LoginComponent },
    { path: 'user', component: UserComponent },
    { path: 'dashboard', component: DashboardComponent },
    { path: 'NachMandate', component: NachMandateComponent },
    { path: 'HistoricalMandate', component: HistoricalMandateComponent },
    { path: 'HolidayMaster', component: HolidayMasterComponent },
    { path: 'RegionMaster', component: RegionMasterComponent },
    { path: 'EmployeeMaster', component: EmployeeMasterComponent },
    { path: 'DesignationMaster', component: DesignationMasterComponent }
];
var AppRoutingModule = /** @class */ (function () {
    function AppRoutingModule() {
    }
    AppRoutingModule = tslib_1.__decorate([
        NgModule({
            imports: [RouterModule.forRoot(routes)],
            exports: [RouterModule]
        })
    ], AppRoutingModule);
    return AppRoutingModule;
}());
export { AppRoutingModule };
