import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
import { FormGroup, Validators, FormControl, FormBuilder } from '@angular/forms';
import { EmployeeServiceService } from './Services/employee-service.service';
var AppComponent = /** @class */ (function () {
    function AppComponent(formBuilder, _employeeService) {
        this.formBuilder = formBuilder;
        this._employeeService = _employeeService;
        this.Emplist = [];
        this.buttonDisabled1 = true;
        this.submitted = false;
        this.sucess = false;
        this.Show = true;
        this.Temp = 1;
        this.Userid = 0;
        this.loading = false;
    }
    AppComponent.prototype.ngOnInit = function () {
        this.Login = this.formBuilder.group({
            FullName: ['', Validators.required],
            Email: ['', [Validators.required, Validators.email, Validators.pattern('^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$')]],
            Password: ['', Validators.required]
        });
        this.setClickedRow = function (index) {
            this.selectedRow = index;
        };
        this.AllEmployee();
    };
    AppComponent.prototype.isFieldValid = function (field) {
        return !this.Login.get(field).valid && this.Login.get(field).touched;
    };
    AppComponent.prototype.displayFieldCss = function (field) {
        return {
            'validate': this.isFieldValid(field),
        };
    };
    AppComponent.prototype.AllEmployee = function () {
        var _this = this;
        this.loading = true;
        this._employeeService.getEmployees().
            subscribe(function (data) {
            _this.employee = data.Table;
        });
        // console.log(sessionStorage.getItem('ID'));
        this.loading = false;
    };
    AppComponent.prototype.SaveEmployee = function () {
        var _this = this;
        this._employeeService.SaveEmployee(JSON.stringify(this.Login.value)).subscribe(function (data) {
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
            _this.Login.reset();
            _this.AllEmployee();
        });
    };
    AppComponent.prototype.onRowClicked = function (data) {
        var Currentrowid = this.Login.value;
        this.Userid = data.EmpId;
        this.Login.controls['FullName'].setValue(data.FullName);
        this.Login.controls['Email'].setValue(data.Email);
        this.Login.controls['Password'].setValue(data.Password);
        this.buttonDisabled1 = false;
        this.Temp = 2;
    };
    AppComponent.prototype.deleteEmp = function () {
        var _this = this;
        this._employeeService.deleteItem(this.Userid).subscribe(function () {
            if (_this.employee.Flag = 1) {
                _this.message = 'Record deleted Successfully';
                alert(_this.message);
                _this.AllEmployee();
                _this.Login.reset();
                _this.buttonDisabled1 = true;
            }
            else {
                _this.message = 'Invalid Credential';
                alert(_this.message);
            }
        });
    };
    AppComponent.prototype.updateItem = function () {
        var _this = this;
        this._employeeService.updateItem(JSON.stringify(this.Login.value), this.Userid).subscribe(function (data) {
            if (_this.employee.Flag = 1) {
                _this.message = 'Record updated Successfully';
                alert(_this.message);
                _this.AllEmployee();
                _this.buttonDisabled1 = true;
            }
            else {
                _this.message = 'Invalid Credential';
                alert(_this.message);
            }
            _this.employee = data;
            _this.Emplist = _this.employee.dataList;
            _this.Login.reset();
        });
    };
    AppComponent.prototype.onSubmit = function () {
        this.submitted = true;
        if (this.Login.valid) {
            //this.sucess=true;
            var datat = this.Login.value;
            if (this.Temp == 1) {
                this.SaveEmployee();
            }
            else {
                this.updateItem();
            }
        }
        else {
            this.validateAllFormFields(this.Login);
        }
    };
    AppComponent.prototype.validateAllFormFields = function (formGroup) {
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
    AppComponent = tslib_1.__decorate([
        Component({
            selector: 'app-root',
            templateUrl: './app.component.html',
            styleUrls: ['./app.component.css']
        }),
        tslib_1.__metadata("design:paramtypes", [FormBuilder, EmployeeServiceService])
    ], AppComponent);
    return AppComponent;
}());
export { AppComponent };
