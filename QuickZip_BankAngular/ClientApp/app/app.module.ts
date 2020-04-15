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
import { RegionMasterComponent } from './master/region-master/region-master.component';
import { HolidayMasterService } from './Services/holiday-master.service'; 
import { HttpClientModule, HttpClient } from '@angular/common/http';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
//import { NgMultiSelectDropDownModule } from 'ng-multiselect-dropdown';
import { EmployeeMasterComponent } from './master/employee-master/employee-master.component';
import { DesignationMasterComponent } from './master/designation-master/designation-master.component';

@NgModule({
  declarations: [
      AppComponent
      , LoginComponent
      , HeaderComponent, FooterComponent, SidebarComponent, UserComponent, DashboardComponent, NachMandateComponent, HistoricalMandateComponent, HolidayMasterComponent, RegionMasterComponent, EmployeeMasterComponent, DesignationMasterComponent
  ],
    imports: [
        BrowserModule,
        AppRoutingModule,
        FormsModule,
        ReactiveFormsModule,
        MatDatepickerModule,
        MatNativeDateModule,
      MatButtonModule,
      MatMenuModule,
      MatDatepickerModule,
      
      MatIconModule,
      MatRadioModule,
      MatCardModule,
      MatSidenavModule,
      
      MatInputModule,
      MatTooltipModule,
        MatToolbarModule, BrowserAnimationsModule,
  ],
    providers: [HttpClientModule,
        BrowserModule,
        AppRoutingModule,
        FormsModule,
        ReactiveFormsModule,
        MatDatepickerModule,
        MatNativeDateModule,
        MatButtonModule,
        MatMenuModule,
        MatDatepickerModule,

        MatIconModule,
        MatRadioModule,
        MatCardModule,
        MatSidenavModule,

        MatInputModule,
        MatTooltipModule,
        MatToolbarModule, BrowserAnimationsModule],

    bootstrap: [AppComponent]  
})
export class AppModule { }
export function getBaseUrl() {
    return document.getElementsByTagName('base')[0].href;
}
