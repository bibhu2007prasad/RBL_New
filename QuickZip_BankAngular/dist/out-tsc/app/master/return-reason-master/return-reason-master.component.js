import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { ReturnRegionService } from 'ClientApp/app/Services/return-region.service';
import { ReturnRegion } from '../../models/ReturnRegion/returnRegion';
var ReturnReasonMasterComponent = /** @class */ (function () {
    function ReturnReasonMasterComponent(formbulider, _returnRegionService) {
        this.formbulider = formbulider;
        this._returnRegionService = _returnRegionService;
        this.Emplist = [];
        this.buttonDisabledReset = false; /*buttonDisabledDelete: boolean = true;*/
        this.submitted = false;
        this.sucess = false;
        this.Show = true;
        this.Temp = 1;
        this.ReasonID = 0;
        this.loading = false;
        this.returnRegion = new ReturnRegion();
        this.returnRegion.dataList = [];
    }
    ReturnReasonMasterComponent.prototype.ngOnInit = function () {
        // debugger;
        this.ReturnRegionFormGroup = this.formbulider.group({
            ReasonCode: ['', [Validators.required]],
            ReturnReason: ['', [Validators.required]],
            Description: ['', [Validators.required]],
            IsActive: [false],
        });
        this.setClickedRow = function (index) {
            this.selectedRow = index;
        };
        // this.AllEmployee();
        debugger;
        this.loadAllReturnRegions();
    };
    ReturnReasonMasterComponent.prototype.isFieldValid = function (field) {
        return !this.ReturnRegionFormGroup.get(field).valid && this.ReturnRegionFormGroup.get(field).touched;
    };
    ReturnReasonMasterComponent.prototype.displayFieldCss = function (field) {
        return {
            'validate': this.isFieldValid(field),
        };
    };
    ReturnReasonMasterComponent.prototype.loadAllReturnRegions = function () {
        debugger;
        this.loading = true;
        var currentContext = this;
        this._returnRegionService.getReturnRegions().
            subscribe(function (data) {
            currentContext.returnRegion.dataList = data.Table;
        });
        // console.log(sessionStorage.getItem('ID'));
        this.loading = false;
    };
    ReturnReasonMasterComponent.prototype.ResetReturnRegion = function () {
        this.ReturnRegionFormGroup.reset();
        this.buttonDisabledReset = false;
        //this.buttonDisabledDelete = true
        this.submitted = false;
        this.sucess = false;
        this.Show = true;
        this.Temp = 1;
        this.ReasonID = 0;
        this.loading = false;
        this.message = null;
        // this.BindDesignations();
    };
    ReturnReasonMasterComponent.prototype.SaveReturnRegion = function () {
        var _this = this;
        //debugger;
        this._returnRegionService.SaveReturnRegion(JSON.stringify(this.ReturnRegionFormGroup.value)).subscribe(function (data) {
            _this.returnRegion = data;
            if (_this.returnRegion.Flag = 1) {
                sessionStorage.setItem('ID', _this.returnRegion.Flag.toString());
                _this.message = 'Record saved Successfully';
                alert(_this.message);
            }
            else {
                _this.message = 'Invalid Credential';
                alert(_this.message);
            }
            //this.ReturnRegionFormGroup.reset();
            //this.loadAllDocuments();
            _this.ResetReturnRegion();
            _this.loadAllReturnRegions();
        });
    };
    ReturnReasonMasterComponent.prototype.onRowClicked = function (data) {
        debugger;
        var Currentrowid = this.ReturnRegionFormGroup.value;
        this.ReasonID = data.ReasonID;
        this.ReturnRegionFormGroup.controls['ReasonCode'].setValue(data.ReasonCode);
        this.ReturnRegionFormGroup.controls['ReturnReason'].setValue(data.ReturnReason);
        this.ReturnRegionFormGroup.controls['Description'].setValue(data.Description);
        this.ReturnRegionFormGroup.controls['IsActive'].setValue((data.IsActive == 'True' ? true : false));
        //this.buttonDisabledDelete = false;
        this.buttonDisabledReset = false;
        this.Temp = 2;
    };
    //DeleteDesignation() {
    //    this._settlemetnService.DeleteDocument(this.Userid).subscribe(() => {
    //        if (this.employee.Flag = 1) {
    //            this.message = 'Record deleted Successfully';
    //            alert(this.message);
    //            this.loadAllDocuments();
    //            this.ReturnRegionFormGroup.reset();
    //            this.buttonDisabledDelete = true;
    //            this.buttonDisabledReset = false;
    //        }
    //        else {
    //            this.message = 'Invalid Credential';
    //            alert(this.message);
    //        }
    //    });
    //}
    ReturnReasonMasterComponent.prototype.UpdateReturnRegion = function () {
        var _this = this;
        this._returnRegionService.UpdateReturnRegion(JSON.stringify(this.ReturnRegionFormGroup.value), this.ReasonID).subscribe(function (data) {
            if (_this.returnRegion.Flag = 1) {
                _this.message = 'Record updated Successfully';
                alert(_this.message);
                //this.buttonDisabledDelete = true;
                _this.buttonDisabledReset = false;
            }
            else {
                _this.message = 'Invalid Credential';
                alert(_this.message);
            }
            _this.returnRegion = data;
            _this.Emplist = _this.returnRegion.dataList;
            //this.ReturnRegionFormGroup.reset();
            _this.ResetReturnRegion();
            _this.loadAllReturnRegions();
        });
    };
    ReturnReasonMasterComponent.prototype.onSubmit = function () {
        debugger;
        //alert('OnSubmi Clicked');
        this.submitted = true;
        if (this.ReturnRegionFormGroup.valid) {
            //this.sucess=true;
            var datat = this.ReturnRegionFormGroup.value;
            if (this.Temp == 1) {
                this.SaveReturnRegion();
            }
            else {
                this.UpdateReturnRegion();
            }
        }
        else {
            this.validateAllFormFields(this.ReturnRegionFormGroup);
        }
    };
    ReturnReasonMasterComponent.prototype.validateAllFormFields = function (formGroup) {
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
    ReturnReasonMasterComponent = tslib_1.__decorate([
        Component({
            selector: 'app-return-reason-master',
            templateUrl: './return-reason-master.component.html',
            styleUrls: ['./return-reason-master.component.css']
        }),
        tslib_1.__metadata("design:paramtypes", [FormBuilder, ReturnRegionService])
    ], ReturnReasonMasterComponent);
    return ReturnReasonMasterComponent;
}());
export { ReturnReasonMasterComponent };
