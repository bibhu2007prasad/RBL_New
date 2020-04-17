import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Holiday } from '../../models/holiday/holiday';
import { HolidayMasterService } from 'ClientApp/app/Services/holiday-master.service';
var HolidayMasterComponent = /** @class */ (function () {
    function HolidayMasterComponent(formbulider, _holidayService) {
        this.formbulider = formbulider;
        this._holidayService = _holidayService;
        this.Emplist = [];
        this.buttonDisabledReset = false;
        this.buttonDisabledDelete = true;
        this.submitted = false;
        this.sucess = false;
        this.Show = true;
        this.Temp = 1;
        this.Userid = 0;
        this.loading = false;
        this.holiday = new Holiday();
        this.holiday.dataList = [];
    }
    HolidayMasterComponent.prototype.ngOnInit = function () {
        this.HolidayForm = this.formbulider.group({
            HolidayName: ['', [Validators.required]],
            HolidayDate: ['', [Validators.required]],
        });
        this.setClickedRow = function (index) {
            this.selectedRow = index;
        };
        // this.AllEmployee();
        this.loadAllHolidays();
    };
    HolidayMasterComponent.prototype.isFieldValid = function (field) {
        return this.HolidayForm.get(field).touched;
    };
    HolidayMasterComponent.prototype.displayFieldCss = function (field) {
        return {
            'validate': this.isFieldValid(field),
        };
    };
    HolidayMasterComponent.prototype.loadAllHolidays = function () {
        this.loading = true;
        var currentContext = this;
        this._holidayService.getHolidays().
            subscribe(function (data) {
            currentContext.holiday.dataList = data.Table;
        });
        // console.log(sessionStorage.getItem('ID'));
        this.loading = false;
    };
    HolidayMasterComponent.prototype.ResetHoliday = function () {
        this.HolidayForm.reset();
        this.buttonDisabledReset = false;
        this.buttonDisabledDelete = true;
        this.submitted = false;
        this.sucess = false;
        this.Show = true;
        this.Temp = 1;
        this.Userid = 0;
        this.loading = false;
        this.message = null;
    };
    HolidayMasterComponent.prototype.SaveHoliday = function () {
        var _this = this;
        this._holidayService.SaveHoliday(JSON.stringify(this.HolidayForm.value)).subscribe(function (data) {
            _this.holiday = data;
            if (_this.holiday.Flag = 1) {
                sessionStorage.setItem('ID', _this.holiday.Flag.toString());
                _this.message = 'Record saved Successfully';
                alert(_this.message);
            }
            else {
                _this.message = 'Invalid Credential';
                alert(_this.message);
            }
            _this.HolidayForm.reset();
            _this.loadAllHolidays();
        });
    };
    HolidayMasterComponent.prototype.onRowClicked = function (data) {
        var Currentrowid = this.HolidayForm.value;
        this.Userid = data.HolidayID;
        ////let oldDate = "24.01.2017";
        ////let newDate = new Date(data.HolidayDate);
        this.HolidayForm.controls['HolidayName'].setValue(data.HolidayName);
        //this.HolidayForm.controls['HolidayDate'].setValue(newDate);
        this.today = new Date(data.HolidayDate);
        this.buttonDisabledDelete = false;
        this.buttonDisabledReset = false;
        this.Temp = 2;
    };
    HolidayMasterComponent.prototype.DeleteHoliday = function () {
        var _this = this;
        this._holidayService.DeleteHoliday(this.Userid).subscribe(function () {
            if (_this.holiday.Flag = 1) {
                _this.message = 'Record deleted Successfully';
                alert(_this.message);
                _this.loadAllHolidays();
                _this.HolidayForm.reset();
                _this.buttonDisabledDelete = true;
                _this.buttonDisabledReset = false;
            }
            else {
                _this.message = 'Invalid Credential';
                alert(_this.message);
            }
        });
    };
    HolidayMasterComponent.prototype.UpdateHoliday = function () {
        var _this = this;
        this._holidayService.UpdateHoliday(JSON.stringify(this.HolidayForm.value), this.Userid).subscribe(function (data) {
            if (_this.holiday.Flag = 1) {
                _this.message = 'Record updated Successfully';
                alert(_this.message);
                _this.loadAllHolidays();
                _this.buttonDisabledDelete = true;
                _this.buttonDisabledReset = false;
            }
            else {
                _this.message = 'Invalid Credential';
                alert(_this.message);
            }
            _this.holiday = data;
            _this.Emplist = _this.holiday.dataList;
            _this.HolidayForm.reset();
        });
    };
    HolidayMasterComponent.prototype.onSubmit = function () {
        //alert('OnSubmi Clicked');
        this.submitted = true;
        if (this.HolidayForm.valid) {
            //this.sucess=true;
            var datat = this.HolidayForm.value;
            if (this.Temp == 1) {
                this.SaveHoliday();
            }
            else {
                this.UpdateHoliday();
            }
        }
        else {
            this.validateAllFormFields(this.HolidayForm);
        }
    };
    HolidayMasterComponent.prototype.validateAllFormFields = function (formGroup) {
        var _this = this;
        Object.keys(formGroup.controls).forEach(function (field) {
            var control = formGroup.get(field);
            if (control instanceof FormControl) {
                control.markAsTouched({ onlySelf: true });
            }
            else if (control instanceof FormGroup) {
                _this.validateAllFormFields(control);
            }
        });
    };
    HolidayMasterComponent = tslib_1.__decorate([
        Component({
            selector: 'app-holiday-master',
            templateUrl: './holiday-master.component.html',
            styleUrls: ['./holiday-master.component.css']
        }),
        tslib_1.__metadata("design:paramtypes", [FormBuilder, HolidayMasterService])
    ], HolidayMasterComponent);
    return HolidayMasterComponent;
}());
export { HolidayMasterComponent };
