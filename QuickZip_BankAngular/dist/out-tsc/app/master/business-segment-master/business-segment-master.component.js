import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { BusinessSegmentService } from 'ClientApp/app/Services/business-segment.service';
import { BusinessSegment } from '../../models/BusinessSegment/businessSegment';
var BusinessSegmentMasterComponent = /** @class */ (function () {
    function BusinessSegmentMasterComponent(formbulider, _businessSegmentService) {
        this.formbulider = formbulider;
        this._businessSegmentService = _businessSegmentService;
        this.Emplist = [];
        this.buttonDisabledReset = false; /*buttonDisabledDelete: boolean = true;*/
        this.submitted = false;
        this.sucess = false;
        this.Show = true;
        this.Temp = 1;
        this.BusinessSegmentID = 0;
        this.loading = false;
        this.businessSegment = new BusinessSegment();
        this.businessSegment.dataList = [];
    }
    BusinessSegmentMasterComponent.prototype.ngOnInit = function () {
        // debugger;
        this.BusinessSegmentFormGroup = this.formbulider.group({
            BusinessSegmentCode: ['', [Validators.required]],
            BusinessSegmentName: ['', [Validators.required]],
            BusinessSegmentDesc: ['', [Validators.required]],
            IsActive: [false],
        });
        this.setClickedRow = function (index) {
            this.selectedRow = index;
        };
        // this.AllEmployee();
        debugger;
        this.loadAllBusinessSegments();
    };
    BusinessSegmentMasterComponent.prototype.isFieldValid = function (field) {
        return !this.BusinessSegmentFormGroup.get(field).valid && this.BusinessSegmentFormGroup.get(field).touched;
    };
    BusinessSegmentMasterComponent.prototype.displayFieldCss = function (field) {
        return {
            'validate': this.isFieldValid(field),
        };
    };
    BusinessSegmentMasterComponent.prototype.loadAllBusinessSegments = function () {
        debugger;
        this.loading = true;
        var currentContext = this;
        this._businessSegmentService.getBusinessSegments().
            subscribe(function (data) {
            currentContext.businessSegment.dataList = data.Table;
        });
        // console.log(sessionStorage.getItem('ID'));
        this.loading = false;
    };
    BusinessSegmentMasterComponent.prototype.ResetBusinessSegment = function () {
        this.BusinessSegmentFormGroup.reset();
        this.buttonDisabledReset = false;
        //this.buttonDisabledDelete = true
        this.submitted = false;
        this.sucess = false;
        this.Show = true;
        this.Temp = 1;
        this.BusinessSegmentID = 0;
        this.loading = false;
        this.message = null;
        // this.BindDesignations();
    };
    BusinessSegmentMasterComponent.prototype.SaveBusinessSegment = function () {
        var _this = this;
        //debugger;
        this._businessSegmentService.SaveBusinessSegment(JSON.stringify(this.BusinessSegmentFormGroup.value)).subscribe(function (data) {
            _this.businessSegment = data;
            if (_this.businessSegment.Flag = 1) {
                sessionStorage.setItem('ID', _this.businessSegment.Flag.toString());
                _this.message = 'Record saved Successfully';
                alert(_this.message);
            }
            else {
                _this.message = 'Invalid Credential';
                alert(_this.message);
            }
            //this.BusinessSegmentFormGroup.reset();
            //this.loadAllDocuments();
            _this.ResetBusinessSegment();
            _this.loadAllBusinessSegments();
        });
    };
    BusinessSegmentMasterComponent.prototype.onRowClicked = function (data) {
        var Currentrowid = this.BusinessSegmentFormGroup.value;
        this.BusinessSegmentID = data.BusinessSegmentID;
        this.BusinessSegmentFormGroup.controls['BusinessSegmentCode'].setValue(data.BusinessSegmentCode);
        this.BusinessSegmentFormGroup.controls['BusinessSegmentName'].setValue(data.BusinessSegmentName);
        this.BusinessSegmentFormGroup.controls['BusinessSegmentDesc'].setValue(data.BusinessSegmentDesc);
        this.BusinessSegmentFormGroup.controls['IsActive'].setValue((data.IsActive == 'Active' ? true : false));
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
    //            this.BusinessSegmentFormGroup.reset();
    //            this.buttonDisabledDelete = true;
    //            this.buttonDisabledReset = false;
    //        }
    //        else {
    //            this.message = 'Invalid Credential';
    //            alert(this.message);
    //        }
    //    });
    //}
    BusinessSegmentMasterComponent.prototype.UpdateBusinessSegment = function () {
        var _this = this;
        this._businessSegmentService.UpdateBusinessSegment(JSON.stringify(this.BusinessSegmentFormGroup.value), this.BusinessSegmentID).subscribe(function (data) {
            if (_this.businessSegment.Flag = 1) {
                _this.message = 'Record updated Successfully';
                alert(_this.message);
                //this.buttonDisabledDelete = true;
                _this.buttonDisabledReset = false;
            }
            else {
                _this.message = 'Invalid Credential';
                alert(_this.message);
            }
            _this.businessSegment = data;
            _this.Emplist = _this.businessSegment.dataList;
            //this.BusinessSegmentFormGroup.reset();
            _this.ResetBusinessSegment();
            _this.loadAllBusinessSegments();
        });
    };
    BusinessSegmentMasterComponent.prototype.onSubmit = function () {
        debugger;
        //alert('OnSubmi Clicked');
        this.submitted = true;
        if (this.BusinessSegmentFormGroup.valid) {
            //this.sucess=true;
            var datat = this.BusinessSegmentFormGroup.value;
            if (this.Temp == 1) {
                this.SaveBusinessSegment();
            }
            else {
                this.UpdateBusinessSegment();
            }
        }
        else {
            this.validateAllFormFields(this.BusinessSegmentFormGroup);
        }
    };
    BusinessSegmentMasterComponent.prototype.validateAllFormFields = function (formGroup) {
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
    BusinessSegmentMasterComponent = tslib_1.__decorate([
        Component({
            selector: 'app-business-segment-master',
            templateUrl: './business-segment-master.component.html',
            styleUrls: ['./business-segment-master.component.css']
        }),
        tslib_1.__metadata("design:paramtypes", [FormBuilder, BusinessSegmentService])
    ], BusinessSegmentMasterComponent);
    return BusinessSegmentMasterComponent;
}());
export { BusinessSegmentMasterComponent };
