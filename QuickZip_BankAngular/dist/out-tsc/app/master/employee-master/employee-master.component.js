import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Employee } from '../../models/Employee/employee';
import { EmployeeMasterService } from 'ClientApp/app/Services/employee-master.service';
import { DDDesignation } from '../../Models/Designation/dddesignation';
var EmployeeMasterComponent = /** @class */ (function () {
    function EmployeeMasterComponent(formbulider, _documentService) {
        this.formbulider = formbulider;
        this._documentService = _documentService;
        this.Emplist = [];
        this.buttonDisabledReset = false; /*buttonDisabledDelete: boolean = true;*/
        this.submitted = false;
        this.sucess = false;
        this.Show = true;
        this.Temp = 1;
        this.EmpId = 0;
        this.loading = false;
        this.employee = new Employee();
        this.employee.dataList = [];
        this.dddesignation = new DDDesignation();
        this.dddesignation.dataList = [];
    }
    EmployeeMasterComponent.prototype.ngOnInit = function () {
        // debugger;
        this.EmployeeForm = this.formbulider.group({
            Emp_Code: ['', [Validators.required]],
            Emp_Name: ['', [Validators.required]],
            PhoneNo: ['', [Validators.required]],
            EmailID: ['', [Validators.required, Validators.email, Validators.pattern('^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$')]],
            DesignationId: [0, [Validators.required]],
            IsActive: [false],
        });
        this.setClickedRow = function (index) {
            this.selectedRow = index;
        };
        // this.AllEmployee();
        this.BindDesignations();
        this.loadAllEmployees();
    };
    EmployeeMasterComponent.prototype.BindDesignations = function () {
        this.loading = true;
        var currentContext = this;
        this._documentService.BindDesignation().
            subscribe(function (data) {
            // this.employee = data.Table;
            currentContext.dddesignation.dataList = data.Table;
        });
        this.loading = false;
    };
    EmployeeMasterComponent.prototype.isFieldValid = function (field) {
        return !this.EmployeeForm.get(field).valid && this.EmployeeForm.get(field).touched;
    };
    EmployeeMasterComponent.prototype.displayFieldCss = function (field) {
        return {
            'validate': this.isFieldValid(field),
        };
    };
    EmployeeMasterComponent.prototype.loadAllEmployees = function () {
        //debugger;
        this.loading = true;
        var currentContext = this;
        this._documentService.getEmployees().
            subscribe(function (data) {
            currentContext.employee.dataList = data.Table;
        });
        // console.log(sessionStorage.getItem('ID'));
        this.loading = false;
    };
    EmployeeMasterComponent.prototype.numberOnly = function (event) {
        debugger;
        var charCode = (event.which) ? event.which : event.keyCode;
        if (charCode > 31 && (charCode < 48 || charCode > 57)) {
            return false;
        }
        return true;
    };
    EmployeeMasterComponent.prototype.ResetEmployee = function () {
        this.EmployeeForm.reset();
        this.EmployeeForm.controls['DesignationId'].setValue(0);
        this.buttonDisabledReset = false;
        //this.buttonDisabledDelete = true
        this.submitted = false;
        this.sucess = false;
        this.Show = true;
        this.Temp = 1;
        this.EmpId = 0;
        this.loading = false;
        this.message = null;
        // this.BindDesignations();
    };
    EmployeeMasterComponent.prototype.SaveEmployee = function () {
        var _this = this;
        //debugger;
        this._documentService.SaveEmployee(JSON.stringify(this.EmployeeForm.value)).subscribe(function (data) {
            _this.employee = data;
            if (_this.employee.Flag = 1) {
                sessionStorage.setItem('ID', _this.employee.Flag.toString());
                _this.message = 'Record saved Successfully';
                alert(_this.message);
            }
            else {
                _this.message = 'Invalid Credential';
                alert(_this.message);
            }
            //this.EmployeeForm.reset();
            //this.loadAllDocuments();
            _this.ResetEmployee();
            _this.loadAllEmployees();
        });
    };
    EmployeeMasterComponent.prototype.onRowClicked = function (data) {
        var Currentrowid = this.EmployeeForm.value;
        this.EmpId = data.EmpId;
        this.EmployeeForm.controls['Emp_Code'].setValue(data.Emp_Code);
        this.EmployeeForm.controls['Emp_Name'].setValue(data.Emp_Name);
        this.EmployeeForm.controls['PhoneNo'].setValue(data.PhoneNo);
        this.EmployeeForm.controls['EmailID'].setValue(data.EmailId);
        this.EmployeeForm.controls['DesignationId'].setValue(data.DesignationId);
        this.EmployeeForm.controls['IsActive'].setValue((data.IsActive == 'Active' ? true : false));
        //this.buttonDisabledDelete = false;
        this.buttonDisabledReset = false;
        this.Temp = 2;
    };
    //DeleteDesignation() {
    //    this._documentService.DeleteDocument(this.Userid).subscribe(() => {
    //        if (this.employee.Flag = 1) {
    //            this.message = 'Record deleted Successfully';
    //            alert(this.message);
    //            this.loadAllDocuments();
    //            this.EmployeeForm.reset();
    //            this.buttonDisabledDelete = true;
    //            this.buttonDisabledReset = false;
    //        }
    //        else {
    //            this.message = 'Invalid Credential';
    //            alert(this.message);
    //        }
    //    });
    //}
    EmployeeMasterComponent.prototype.UpdateEmployee = function () {
        var _this = this;
        this._documentService.UpdateEmployee(JSON.stringify(this.EmployeeForm.value), this.EmpId).subscribe(function (data) {
            if (_this.employee.Flag = 1) {
                _this.message = 'Record updated Successfully';
                alert(_this.message);
                //this.buttonDisabledDelete = true;
                _this.buttonDisabledReset = false;
            }
            else {
                _this.message = 'Invalid Credential';
                alert(_this.message);
            }
            _this.employee = data;
            _this.Emplist = _this.employee.dataList;
            //this.EmployeeForm.reset();
            _this.ResetEmployee();
            _this.loadAllEmployees();
        });
    };
    EmployeeMasterComponent.prototype.onSubmit = function () {
        debugger;
        //alert('OnSubmi Clicked');
        this.submitted = true;
        if (this.EmployeeForm.valid) {
            //this.sucess=true;
            var datat = this.EmployeeForm.value;
            if (this.Temp == 1) {
                this.SaveEmployee();
            }
            else {
                this.UpdateEmployee();
            }
        }
        else {
            this.validateAllFormFields(this.EmployeeForm);
        }
    };
    EmployeeMasterComponent.prototype.validateAllFormFields = function (formGroup) {
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
    EmployeeMasterComponent = tslib_1.__decorate([
        Component({
            selector: 'app-employee-master',
            templateUrl: './employee-master.component.html',
            styleUrls: ['./employee-master.component.css']
        }),
        tslib_1.__metadata("design:paramtypes", [FormBuilder, EmployeeMasterService])
    ], EmployeeMasterComponent);
    return EmployeeMasterComponent;
}());
export { EmployeeMasterComponent };
