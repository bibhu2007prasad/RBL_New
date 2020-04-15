
import { Component, OnInit, Inject } from '@angular/core';
import { FormsModule,FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Holiday } from '../../models/holiday/holiday';

import { HolidayMasterService } from 'ClientApp/app/Services/holiday-master.service';
import { UrlSegment } from '@angular/router';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Component({
  selector: 'app-holiday-master',
  templateUrl: './holiday-master.component.html',
  styleUrls: ['./holiday-master.component.css']
})
export class HolidayMasterComponent implements OnInit {
    HolidayForm: FormGroup; holiday: Holiday; Emplist = []; buttonDisabledReset: boolean = true;buttonDisabledDelete: boolean = true; submitted = false; sucess = false; Show = true;
    Temp: number = 1; Userid: number = 0; loading: boolean = false;
    message: string;
    setClickedRow: Function;
    games: [{
        HolidayID: string,
        HolidayName: string,
        HolidayDate: string
    }];
    constructor(private formbulider: FormBuilder, private _holidayService: HolidayMasterService) {
        debugger;
        this.holiday = new Holiday();
        this.holiday.dataList =[];
    }

    ngOnInit() {
        // debugger;
        this.HolidayForm = this.formbulider.group({
            HolidayName: ['', [Validators.required]],
            Date: ['', [Validators.required]],
           
        });
        this.setClickedRow = function (index) {
            this.selectedRow = index;
        }
       // this.AllEmployee();
        this.loadAllHolidays();
    }
    isFieldValid(field: string) {
        return this.HolidayForm.get(field).touched;
    }
    displayFieldCss(field: string) {
        return {
            'validate': this.isFieldValid(field),
        };
    }
    loadAllHolidays() {
        debugger;
        this.loading = true;
        var currentContext = this;
        this._holidayService.getHolidays().
            subscribe((data) => {
                currentContext.holiday.dataList = data.Table;
            });
        // console.log(sessionStorage.getItem('ID'));
        this.loading = false;
    }
    ResetHoliday() {
        this.HolidayForm.reset();
        this.buttonDisabledReset = true;
        this.buttonDisabledDelete = true
        this.submitted = false;
        this.sucess = false;
        this.Show = true;
        this.Temp = 1;
        this.Userid = 0;
        this.loading = false;
        this.message = null;
    }
    SaveHoliday() {
        debugger;
        this._holidayService.SaveHoliday(JSON.stringify(this.HolidayForm.value)).subscribe(
            (data) => {
                this.holiday = data;
                if (this.holiday.Flag = 1) {
                    sessionStorage.setItem('ID', this.holiday.Flag.toString());
                    this.message = 'Record saved Successfully';
                    alert(this.message);
                }
                else {
                    this.message = 'Invalid Credential';
                    alert(this.message);
                }
                this.HolidayForm.reset();
                this.loadAllHolidays();
            }
        )
    }
    onRowClicked(data: any) {
        const Currentrowid = this.HolidayForm.value;
        this.Userid = data.HolidayID;
        this.HolidayForm.controls['HolidayName'].setValue(data.HolidayName);
        this.HolidayForm.controls['Date'].setValue(data.HolidayDate);
        
        this.buttonDisabledDelete = false;
        this.buttonDisabledReset = false;
        this.Temp = 2;
    }
    DeleteHoliday() {
        this._holidayService.DeleteHoliday(this.Userid).subscribe(() => {
            if (this.holiday.Flag = 1) {
                this.message = 'Record deleted Successfully';
                alert(this.message);
                this.loadAllHolidays();
                this.HolidayForm.reset();
                this.buttonDisabledDelete = true;
                this.buttonDisabledReset = true;
            }
            else {
                this.message = 'Invalid Credential';
                alert(this.message);
            }
        });
    }
    UpdateHoliday() {
        this._holidayService.UpdateHoliday(JSON.stringify(this.HolidayForm.value), this.Userid).subscribe(
            (data) => {
                if (this.holiday.Flag = 1) {
                    this.message = 'Record updated Successfully';
                    alert(this.message);
                    this.loadAllHolidays()

                    this.buttonDisabledDelete = true;
                    this.buttonDisabledReset = true;
                }
                else {
                    this.message = 'Invalid Credential';
                    alert(this.message);
                }
                this.holiday = data;
                this.Emplist = this.holiday.dataList;
                this.HolidayForm.reset();
            }
        )
    }
    onSubmit() {
        debugger;
        //alert('OnSubmi Clicked');
        this.submitted = true;
        if (this.HolidayForm.valid) {
            //this.sucess=true;
            const datat = this.HolidayForm.value;
            if (this.Temp == 1) {
                this.SaveHoliday();
            }
            else {
                this.UpdateHoliday();
            }
        } else {
            this.validateAllFormFields(this.HolidayForm);
        }
    }
    validateAllFormFields(formGroup: FormGroup) {
        Object.keys(formGroup.controls).forEach(field => {
            const control = formGroup.get(field);
            if (control instanceof FormControl) {
                control.markAsTouched({ onlySelf: true });
            } else if (control instanceof FormGroup) {
                this.validateAllFormFields(control);
            }
        });
    }

}
