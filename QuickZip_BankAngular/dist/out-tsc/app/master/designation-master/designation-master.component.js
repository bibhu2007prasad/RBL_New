import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Designation } from '../../models/Designation/designation';
import { DesignationMasterService } from 'ClientApp/app/Services/designation-master.service';
var DesignationMasterComponent = /** @class */ (function () {
    function DesignationMasterComponent(formbulider, _designationService) {
        this.formbulider = formbulider;
        this._designationService = _designationService;
        this.Emplist = [];
        this.buttonDisabledReset = false;
        this.buttonDisabledDelete = true;
        this.submitted = false;
        this.sucess = false;
        this.Show = true;
        this.Temp = 1;
        this.Userid = 0;
        this.loading = false;
        debugger;
        this.designation = new Designation();
        this.designation.dataList = [];
    }
    DesignationMasterComponent.prototype.ngOnInit = function () {
        // debugger;
        this.DesignationForm = this.formbulider.group({
            DesignationCode: ['', [Validators.required]],
            DesignationName: ['', [Validators.required]],
            Active: ['', [Validators.required]],
        });
        this.setClickedRow = function (index) {
            this.selectedRow = index;
        };
        // this.AllEmployee();
        this.loadAllDegignations();
    };
    DesignationMasterComponent.prototype.isFieldValid = function (field) {
        return this.DesignationForm.get(field).touched;
    };
    DesignationMasterComponent.prototype.displayFieldCss = function (field) {
        return {
            'validate': this.isFieldValid(field),
        };
    };
    DesignationMasterComponent.prototype.loadAllDegignations = function () {
        debugger;
        this.loading = true;
        var currentContext = this;
        this._designationService.getDesignations().
            subscribe(function (data) {
            currentContext.designation.dataList = data.Table;
        });
        // console.log(sessionStorage.getItem('ID'));
        this.loading = false;
    };
    DesignationMasterComponent.prototype.ResetDesignation = function () {
        this.DesignationForm.reset();
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
    DesignationMasterComponent.prototype.SaveDesignation = function () {
        var _this = this;
        debugger;
        this._designationService.SaveDesignation(JSON.stringify(this.DesignationForm.value)).subscribe(function (data) {
            _this.designation = data;
            if (_this.designation.Flag = 1) {
                sessionStorage.setItem('ID', _this.designation.Flag.toString());
                _this.message = 'Record saved Successfully';
                alert(_this.message);
            }
            else {
                _this.message = 'Invalid Credential';
                alert(_this.message);
            }
            _this.DesignationForm.reset();
            _this.loadAllDegignations();
        });
    };
    DesignationMasterComponent.prototype.onRowClicked = function (data) {
        var Currentrowid = this.DesignationForm.value;
        this.Userid = data.DId;
        this.DesignationForm.controls['DesignationCode'].setValue(data.DesignationCode);
        this.DesignationForm.controls['DesignationName'].setValue(data.DesignationName);
        //this.DesignationForm.controls['Active'].setValue(data.Active);
        this.buttonDisabledDelete = false;
        this.buttonDisabledReset = false;
        this.Temp = 2;
    };
    DesignationMasterComponent.prototype.DeleteDesignation = function () {
        var _this = this;
        this._designationService.DeleteDesignation(this.Userid).subscribe(function () {
            if (_this.designation.Flag = 1) {
                _this.message = 'Record deleted Successfully';
                alert(_this.message);
                _this.loadAllDegignations();
                _this.DesignationForm.reset();
                _this.buttonDisabledDelete = true;
                _this.buttonDisabledReset = false;
            }
            else {
                _this.message = 'Invalid Credential';
                alert(_this.message);
            }
        });
    };
    DesignationMasterComponent.prototype.UpdateDesignation = function () {
        var _this = this;
        this._designationService.UpdateDesignation(JSON.stringify(this.DesignationForm.value), this.Userid).subscribe(function (data) {
            if (_this.designation.Flag = 1) {
                _this.message = 'Record updated Successfully';
                alert(_this.message);
                _this.loadAllDegignations();
                _this.buttonDisabledDelete = true;
                _this.buttonDisabledReset = false;
            }
            else {
                _this.message = 'Invalid Credential';
                alert(_this.message);
            }
            _this.designation = data;
            _this.Emplist = _this.designation.dataList;
            _this.DesignationForm.reset();
        });
    };
    DesignationMasterComponent.prototype.onSubmit = function () {
        debugger;
        //alert('OnSubmi Clicked');
        this.submitted = true;
        if (this.DesignationForm.valid) {
            //this.sucess=true;
            var datat = this.DesignationForm.value;
            if (this.Temp == 1) {
                this.SaveDesignation();
            }
            else {
                this.UpdateDesignation();
            }
        }
        else {
            this.validateAllFormFields(this.DesignationForm);
        }
    };
    DesignationMasterComponent.prototype.validateAllFormFields = function (formGroup) {
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
    DesignationMasterComponent = tslib_1.__decorate([
        Component({
            selector: 'app-designation-master',
            templateUrl: './designation-master.component.html',
            styleUrls: ['./designation-master.component.css']
        }),
        tslib_1.__metadata("design:paramtypes", [FormBuilder, DesignationMasterService])
    ], DesignationMasterComponent);
    return DesignationMasterComponent;
}());
export { DesignationMasterComponent };
