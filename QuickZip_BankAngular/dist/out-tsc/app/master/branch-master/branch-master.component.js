import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { BranchMaster } from '../../models/BranchMaster/branchMaster';
import { State } from '../../models/BranchMaster/state';
import { BranchMasterService } from 'ClientApp/app/Services/branch-master.service';
var BranchMasterComponent = /** @class */ (function () {
    function BranchMasterComponent(formbulider, _branchService) {
        this.formbulider = formbulider;
        this._branchService = _branchService;
        this.Emplist = [];
        this.buttonDisabledReset = false; /*buttonDisabledDelete: boolean = true;*/
        this.submitted = false;
        this.sucess = false;
        this.Show = true;
        this.Temp = 1;
        this.BranchId = 0;
        this.loading = false;
        this.branchMaster = new BranchMaster();
        this.branchMaster.dataList = [];
        this.state = new State();
        this.state.dataList = [];
    }
    BranchMasterComponent.prototype.ngOnInit = function () {
        // debugger;
        this.BranchFormGroup = this.formbulider.group({
            BranchCode: ['', [Validators.required]],
            BranchName: ['', [Validators.required]],
            IFSC: ['', [Validators.required]],
            Address: ['', [Validators.required]],
            MICR: ['',],
            StateId: [0, [Validators.required]],
            IsActive: [false],
        });
        this.setClickedRow = function (index) {
            this.selectedRow = index;
        };
        // this.AllBranchMaster();
        debugger;
        this.BindStates();
        this.loadAllBranchMasters();
    };
    BranchMasterComponent.prototype.BindStates = function () {
        this.loading = true;
        var currentContext = this;
        this._branchService.BindStates().
            subscribe(function (data) {
            // this.branchMaster = data.Table;
            currentContext.state.dataList = data.Table;
        });
        this.loading = false;
    };
    BranchMasterComponent.prototype.isFieldValid = function (field) {
        return !this.BranchFormGroup.get(field).valid && this.BranchFormGroup.get(field).touched;
    };
    BranchMasterComponent.prototype.displayFieldCss = function (field) {
        return {
            'validate': this.isFieldValid(field),
        };
    };
    BranchMasterComponent.prototype.loadAllBranchMasters = function () {
        //debugger;
        this.loading = true;
        var currentContext = this;
        this._branchService.getBranchMasters().
            subscribe(function (data) {
            currentContext.branchMaster.dataList = data.Table;
        });
        // console.log(sessionStorage.getItem('ID'));
        this.loading = false;
    };
    BranchMasterComponent.prototype.numberOnly = function (event) {
        debugger;
        var charCode = (event.which) ? event.which : event.keyCode;
        if (charCode > 31 && (charCode < 48 || charCode > 57)) {
            return false;
        }
        return true;
    };
    BranchMasterComponent.prototype.ResetBranch = function () {
        this.BranchFormGroup.reset();
        this.BranchFormGroup.controls['StateId'].setValue(0);
        this.buttonDisabledReset = false;
        //this.buttonDisabledDelete = true
        this.submitted = false;
        this.sucess = false;
        this.Show = true;
        this.Temp = 1;
        this.BranchId = 0;
        this.loading = false;
        this.message = null;
        // this.BindDesignations();
    };
    BranchMasterComponent.prototype.SaveBranchMaster = function () {
        var _this = this;
        //debugger;
        this._branchService.SaveBranchMaster(JSON.stringify(this.BranchFormGroup.value)).subscribe(function (data) {
            _this.branchMaster = data;
            if (_this.branchMaster.Flag = 1) {
                sessionStorage.setItem('ID', _this.branchMaster.Flag.toString());
                _this.message = 'Record saved Successfully';
                alert(_this.message);
            }
            else {
                _this.message = 'Invalid Credential';
                alert(_this.message);
            }
            //this.BranchFormGroup.reset();
            //this.loadAllDocuments();
            _this.ResetBranch();
            _this.loadAllBranchMasters();
        });
    };
    BranchMasterComponent.prototype.onRowClicked = function (data) {
        debugger;
        var Currentrowid = this.BranchFormGroup.value;
        this.BranchId = data.BranchId;
        this.BranchFormGroup.controls['BranchCode'].setValue(data.BranchCode);
        this.BranchFormGroup.controls['BranchName'].setValue(data.BranchName);
        this.BranchFormGroup.controls['IFSC'].setValue(data.IFSC);
        this.BranchFormGroup.controls['Address'].setValue(data.Address);
        this.BranchFormGroup.controls['MICR'].setValue(data.MICR);
        this.BranchFormGroup.controls['StateId'].setValue(data.StateId);
        this.BranchFormGroup.controls['IsActive'].setValue(data.IsActive);
        //this.buttonDisabledDelete = false;
        this.buttonDisabledReset = false;
        this.Temp = 2;
    };
    //DeleteDesignation() {
    //    this._branchService.DeleteDocument(this.Userid).subscribe(() => {
    //        if (this.branchMaster.Flag = 1) {
    //            this.message = 'Record deleted Successfully';
    //            alert(this.message);
    //            this.loadAllDocuments();
    //            this.BranchFormGroup.reset();
    //            this.buttonDisabledDelete = true;
    //            this.buttonDisabledReset = false;
    //        }
    //        else {
    //            this.message = 'Invalid Credential';
    //            alert(this.message);
    //        }
    //    });
    //}
    BranchMasterComponent.prototype.UpdateBranchMaster = function () {
        var _this = this;
        this._branchService.UpdateBranchMaster(JSON.stringify(this.BranchFormGroup.value), this.BranchId).subscribe(function (data) {
            if (_this.branchMaster.Flag = 1) {
                _this.message = 'Record updated Successfully';
                alert(_this.message);
                //this.buttonDisabledDelete = true;
                _this.buttonDisabledReset = false;
            }
            else {
                _this.message = 'Invalid Credential';
                alert(_this.message);
            }
            _this.branchMaster = data;
            _this.Emplist = _this.branchMaster.dataList;
            //this.BranchFormGroup.reset();
            _this.ResetBranch();
            _this.loadAllBranchMasters();
        });
    };
    BranchMasterComponent.prototype.onSubmit = function () {
        debugger;
        //alert('OnSubmi Clicked');
        this.submitted = true;
        if (this.BranchFormGroup.valid) {
            //this.sucess=true;
            var datat = this.BranchFormGroup.value;
            if (this.Temp == 1) {
                this.SaveBranchMaster();
            }
            else {
                this.UpdateBranchMaster();
            }
        }
        else {
            this.validateAllFormFields(this.BranchFormGroup);
        }
    };
    BranchMasterComponent.prototype.validateAllFormFields = function (formGroup) {
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
    BranchMasterComponent = tslib_1.__decorate([
        Component({
            selector: 'app-branch-master',
            templateUrl: './branch-master.component.html',
            styleUrls: ['./branch-master.component.css']
        }),
        tslib_1.__metadata("design:paramtypes", [FormBuilder, BranchMasterService])
    ], BranchMasterComponent);
    return BranchMasterComponent;
}());
export { BranchMasterComponent };
