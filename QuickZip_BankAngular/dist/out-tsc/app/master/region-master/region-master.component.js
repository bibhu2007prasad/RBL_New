import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { RegionMaster } from '../../models/RegionMaster/regionMaster';
import { State } from '../../models/BranchMaster/state';
import { RegionMasterService } from 'ClientApp/app/Services/region-master.service';
//import { IDropdownSettings } from 'ng-multiselect-dropdown';
var RegionMasterComponent = /** @class */ (function () {
    function RegionMasterComponent(formbulider, _regionService) {
        this.formbulider = formbulider;
        this._regionService = _regionService;
        this.Emplist = [];
        this.buttonDisabledReset = false; /*buttonDisabledDelete: boolean = true;*/
        this.submitted = false;
        this.sucess = false;
        this.Show = true;
        this.Temp = 1;
        this.RegionID = 0;
        this.loading = false;
        this.regionMaster = new RegionMaster();
        this.regionMaster.dataList = [];
        this.state = new State();
        this.state.dataList = [];
    }
    RegionMasterComponent.prototype.ngOnInit = function () {
        // debugger;
        this.RegionMasterFormGroup = this.formbulider.group({
            RegionCode: ['', [Validators.required]],
            RegionName: ['', [Validators.required]],
            StateIDs: [0, [Validators.required]],
            IsActive: [false],
        });
        this.setClickedRow = function (index) {
            this.selectedRow = index;
        };
        // this.AllRegionMaster();
        debugger;
        this.BindStates();
        this.loadAllRegionMasters();
    };
    RegionMasterComponent.prototype.BindStates = function () {
        this.loading = true;
        var currentContext = this;
        this._regionService.BindStates().
            subscribe(function (data) {
            // this.RegionMaster = data.Table;
            currentContext.state.dataList = data.Table;
        });
        this.loading = false;
    };
    RegionMasterComponent.prototype.isFieldValid = function (field) {
        return !this.RegionMasterFormGroup.get(field).valid && this.RegionMasterFormGroup.get(field).touched;
    };
    RegionMasterComponent.prototype.displayFieldCss = function (field) {
        return {
            'validate': this.isFieldValid(field),
        };
    };
    RegionMasterComponent.prototype.loadAllRegionMasters = function () {
        //debugger;
        this.loading = true;
        var currentContext = this;
        this._regionService.getRegionMasters().
            subscribe(function (data) {
            currentContext.regionMaster.dataList = data.Table;
        });
        // console.log(sessionStorage.getItem('ID'));
        this.loading = false;
    };
    RegionMasterComponent.prototype.numberOnly = function (event) {
        debugger;
        var charCode = (event.which) ? event.which : event.keyCode;
        if (charCode > 31 && (charCode < 48 || charCode > 57)) {
            return false;
        }
        return true;
    };
    RegionMasterComponent.prototype.ResetRegion = function () {
        this.RegionMasterFormGroup.reset();
        this.RegionMasterFormGroup.controls['StateIds'].setValue(0);
        this.buttonDisabledReset = false;
        //this.buttonDisabledDelete = true
        this.submitted = false;
        this.sucess = false;
        this.Show = true;
        this.Temp = 1;
        this.RegionID = 0;
        this.loading = false;
        this.message = null;
        // this.BindDesignations();
    };
    RegionMasterComponent.prototype.SaveRegionMaster = function () {
        var _this = this;
        //debugger;
        this._regionService.SaveRegionMaster(JSON.stringify(this.RegionMasterFormGroup.value)).subscribe(function (data) {
            _this.regionMaster = data;
            if (_this.regionMaster.Flag = 1) {
                sessionStorage.setItem('ID', _this.regionMaster.Flag.toString());
                _this.message = 'Record saved Successfully';
                alert(_this.message);
            }
            else {
                _this.message = 'Invalid Credential';
                alert(_this.message);
            }
            //this.RegionMasterFormGroup.reset();
            //this.loadAllDocuments();
            _this.ResetRegion();
            _this.loadAllRegionMasters();
        });
    };
    RegionMasterComponent.prototype.onRowClicked = function (data) {
        debugger;
        var Currentrowid = this.RegionMasterFormGroup.value;
        this.RegionID = data.RegionID;
        this.RegionMasterFormGroup.controls['RegionCode'].setValue(data.RegionCode);
        this.RegionMasterFormGroup.controls['RegionName'].setValue(data.RegionName);
        this.RegionMasterFormGroup.controls['StateIDs'].setValue(data.StateIDs);
        this.RegionMasterFormGroup.controls['IsActive'].setValue(data.IsActive);
        //this.buttonDisabledDelete = false;
        this.buttonDisabledReset = false;
        this.Temp = 2;
    };
    //DeleteDesignation() {
    //    this._regionService.DeleteDocument(this.Userid).subscribe(() => {
    //        if (this.RegionMaster.Flag = 1) {
    //            this.message = 'Record deleted Successfully';
    //            alert(this.message);
    //            this.loadAllDocuments();
    //            this.RegionMasterFormGroup.reset();
    //            this.buttonDisabledDelete = true;
    //            this.buttonDisabledReset = false;
    //        }
    //        else {
    //            this.message = 'Invalid Credential';
    //            alert(this.message);
    //        }
    //    });
    //}
    RegionMasterComponent.prototype.UpdateRegionMaster = function () {
        var _this = this;
        this._regionService.UpdateRegionMaster(JSON.stringify(this.RegionMasterFormGroup.value), this.RegionID).subscribe(function (data) {
            if (_this.regionMaster.Flag = 1) {
                _this.message = 'Record updated Successfully';
                alert(_this.message);
                //this.buttonDisabledDelete = true;
                _this.buttonDisabledReset = false;
            }
            else {
                _this.message = 'Invalid Credential';
                alert(_this.message);
            }
            _this.regionMaster = data;
            _this.Emplist = _this.regionMaster.dataList;
            //this.RegionMasterFormGroup.reset();
            _this.ResetRegion();
            _this.loadAllRegionMasters();
        });
    };
    RegionMasterComponent.prototype.onSubmit = function () {
        debugger;
        //alert('OnSubmi Clicked');
        this.submitted = true;
        if (this.RegionMasterFormGroup.valid) {
            //this.sucess=true;
            var datat = this.RegionMasterFormGroup.value;
            if (this.Temp == 1) {
                this.SaveRegionMaster();
            }
            else {
                this.UpdateRegionMaster();
            }
        }
        else {
            this.validateAllFormFields(this.RegionMasterFormGroup);
        }
    };
    RegionMasterComponent.prototype.validateAllFormFields = function (formGroup) {
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
    RegionMasterComponent = tslib_1.__decorate([
        Component({
            selector: 'app-region-master',
            templateUrl: './region-master.component.html',
            styleUrls: ['./region-master.component.css']
        }),
        tslib_1.__metadata("design:paramtypes", [FormBuilder, RegionMasterService])
    ], RegionMasterComponent);
    return RegionMasterComponent;
}());
export { RegionMasterComponent };
//    dropdownList = [];
//    selectedItems = [];
//    dropdownSettings = {};
//    ngOnInit() {
//        this.dropdownList = [
//            { item_id: 1, item_text: 'Mumbai' },
//            { item_id: 2, item_text: 'Bangaluru' },
//            { item_id: 3, item_text: 'Pune' },
//            { item_id: 4, item_text: 'Navsari' },
//            { item_id: 5, item_text: 'New Delhi' }
//        ];
//        this.selectedItems = [
//            { item_id: 3, item_text: 'Pune' },
//            { item_id: 4, item_text: 'Navsari' }
//        ];
//        //this.dropdownSettings: IDropdownSettings = {
//        //    singleSelection: false,
//        //    idField: 'item_id',
//        //    textField: 'item_text',
//        //    selectAllText: 'Select All',
//        //    unSelectAllText: 'UnSelect All',
//        //    itemsShowLimit: 3,
//        //    allowSearchFilter: true
//        //};
//    }
//    onItemSelect(item: any) {
//        console.log(item);
//    }
//    onSelectAll(items: any) {
//        console.log(items);
//    }
//}
