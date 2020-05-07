import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { SettlementtypeMasterService } from 'ClientApp/app/Services/settlementtype-master.service';
import { SettlementType } from '../../models/SettlementType/settlementType';
var SettlementTypeMasterComponent = /** @class */ (function () {
    function SettlementTypeMasterComponent(formbulider, _settlemetnService) {
        this.formbulider = formbulider;
        this._settlemetnService = _settlemetnService;
        this.Emplist = [];
        this.buttonDisabledReset = false; /*buttonDisabledDelete: boolean = true;*/
        this.submitted = false;
        this.sucess = false;
        this.Show = true;
        this.Temp = 1;
        this.SettleMentTypeID = 0;
        this.loading = false;
        this.settlementType = new SettlementType();
        this.settlementType.dataList = [];
    }
    SettlementTypeMasterComponent.prototype.ngOnInit = function () {
        // debugger;
        this.SettlementFormGroup = this.formbulider.group({
            SettlementCode: ['', [Validators.required]],
            SettlementType: ['', [Validators.required]],
            Description: ['', [Validators.required]],
            IsActive: [false],
        });
        this.setClickedRow = function (index) {
            this.selectedRow = index;
        };
        // this.AllEmployee();
        debugger;
        this.loadAllSettlementTypes();
    };
    SettlementTypeMasterComponent.prototype.isFieldValid = function (field) {
        return !this.SettlementFormGroup.get(field).valid && this.SettlementFormGroup.get(field).touched;
    };
    SettlementTypeMasterComponent.prototype.displayFieldCss = function (field) {
        return {
            'validate': this.isFieldValid(field),
        };
    };
    SettlementTypeMasterComponent.prototype.loadAllSettlementTypes = function () {
        debugger;
        this.loading = true;
        var currentContext = this;
        this._settlemetnService.getSettlementTypes().
            subscribe(function (data) {
            currentContext.settlementType.dataList = data.Table;
        });
        // console.log(sessionStorage.getItem('ID'));
        this.loading = false;
    };
    SettlementTypeMasterComponent.prototype.ResetSettlementType = function () {
        this.SettlementFormGroup.reset();
        this.buttonDisabledReset = false;
        //this.buttonDisabledDelete = true
        this.submitted = false;
        this.sucess = false;
        this.Show = true;
        this.Temp = 1;
        this.SettleMentTypeID = 0;
        this.loading = false;
        this.message = null;
        // this.BindDesignations();
    };
    SettlementTypeMasterComponent.prototype.SaveSettlementType = function () {
        var _this = this;
        //debugger;
        this._settlemetnService.SaveSettlementType(JSON.stringify(this.SettlementFormGroup.value)).subscribe(function (data) {
            _this.settlementType = data;
            if (_this.settlementType.Flag = 1) {
                sessionStorage.setItem('ID', _this.settlementType.Flag.toString());
                _this.message = 'Record saved Successfully';
                alert(_this.message);
            }
            else {
                _this.message = 'Invalid Credential';
                alert(_this.message);
            }
            //this.SettlementFormGroup.reset();
            //this.loadAllDocuments();
            _this.ResetSettlementType();
            _this.loadAllSettlementTypes();
        });
    };
    SettlementTypeMasterComponent.prototype.onRowClicked = function (data) {
        var Currentrowid = this.SettlementFormGroup.value;
        this.SettleMentTypeID = data.SettleMentTypeID;
        this.SettlementFormGroup.controls['SettlementCode'].setValue(data.SettlementCode);
        this.SettlementFormGroup.controls['SettlementType'].setValue(data.SettlementType);
        this.SettlementFormGroup.controls['Description'].setValue(data.Description);
        this.SettlementFormGroup.controls['IsActive'].setValue((data.IsActive == 'Active' ? true : false));
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
    //            this.SettlementFormGroup.reset();
    //            this.buttonDisabledDelete = true;
    //            this.buttonDisabledReset = false;
    //        }
    //        else {
    //            this.message = 'Invalid Credential';
    //            alert(this.message);
    //        }
    //    });
    //}
    SettlementTypeMasterComponent.prototype.UpdateSettlementType = function () {
        var _this = this;
        this._settlemetnService.UpdateSettlementType(JSON.stringify(this.SettlementFormGroup.value), this.SettleMentTypeID).subscribe(function (data) {
            if (_this.settlementType.Flag = 1) {
                _this.message = 'Record updated Successfully';
                alert(_this.message);
                //this.buttonDisabledDelete = true;
                _this.buttonDisabledReset = false;
            }
            else {
                _this.message = 'Invalid Credential';
                alert(_this.message);
            }
            _this.settlementType = data;
            _this.Emplist = _this.settlementType.dataList;
            //this.SettlementFormGroup.reset();
            _this.ResetSettlementType();
            _this.loadAllSettlementTypes();
        });
    };
    SettlementTypeMasterComponent.prototype.onSubmit = function () {
        debugger;
        //alert('OnSubmi Clicked');
        this.submitted = true;
        if (this.SettlementFormGroup.valid) {
            //this.sucess=true;
            var datat = this.SettlementFormGroup.value;
            if (this.Temp == 1) {
                this.SaveSettlementType();
            }
            else {
                this.UpdateSettlementType();
            }
        }
        else {
            this.validateAllFormFields(this.SettlementFormGroup);
        }
    };
    SettlementTypeMasterComponent.prototype.validateAllFormFields = function (formGroup) {
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
    SettlementTypeMasterComponent = tslib_1.__decorate([
        Component({
            selector: 'app-settlement-type-master',
            templateUrl: './settlement-type-master.component.html',
            styleUrls: ['./settlement-type-master.component.css']
        }),
        tslib_1.__metadata("design:paramtypes", [FormBuilder, SettlementtypeMasterService])
    ], SettlementTypeMasterComponent);
    return SettlementTypeMasterComponent;
}());
export { SettlementTypeMasterComponent };
