import { Component, OnInit } from '@angular/core';

import { FormsModule, FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Employee } from '../../models/Employee/employee';

import { EmployeeMasterService } from 'ClientApp/app/Services/employee-master.service';
import { UrlSegment } from '@angular/router';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Designation } from '../../models/Designation/designation';
import { DDDesignation } from '../../Models/Designation/dddesignation';



@Component({
  selector: 'app-employee-master',
  templateUrl: './employee-master.component.html',
  styleUrls: ['./employee-master.component.css']
})
export class EmployeeMasterComponent implements OnInit {

    
    EmployeeForm: FormGroup; employee: Employee; dddesignation: DDDesignation;Emplist = []; buttonDisabledReset: boolean = false; /*buttonDisabledDelete: boolean = true;*/ submitted = false; sucess = false; Show = true;
    Temp: number = 1; EmpId: number = 0; loading: boolean = false;
    message: string;
    setClickedRow: Function;
    games: [{
        DocumentCode: string,
        DocumentName: string,
        DocumentTypeid: string
    }];
    constructor(private formbulider: FormBuilder, private _documentService: EmployeeMasterService) {

        this.employee = new Employee();
        this.employee.dataList = [];
        this.dddesignation = new DDDesignation();
        this.dddesignation.dataList = [];
    }

    ngOnInit() {
        // debugger;
        this.EmployeeForm = this.formbulider.group({
            EmployeeCode: ['', [Validators.required]],
            EmployeeName: ['', [Validators.required]],

            ContactNo: ['', [Validators.required]],
            EmailID: ['', [Validators.required, Validators.email, Validators.pattern('^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$')]],

            DesignationId: ['', [Validators.required]],
            IsActive: ['', [Validators.required]],

        });
        this.setClickedRow = function (index) {
            this.selectedRow = index;
        }
        // this.AllEmployee();
        this.BindDesignations();
        this.loadAllEmployees();
    }

    BindDesignations() {
        this.loading = true;
        var currentContext = this;
        this._documentService.BindDesignation().
            subscribe((data) => {
                // this.employee = data.Table;
                currentContext.dddesignation.dataList = data.Table;
            });
        this.loading = false;
    }
    isFieldValid(field: string) {
        return !this.EmployeeForm.get(field).valid && this.EmployeeForm.get(field).touched;
    }
    displayFieldCss(field: string) {
        return {
            'validate': this.isFieldValid(field),
        };
    }
    loadAllEmployees() {
        //debugger;
        this.loading = true;
        var currentContext = this;
        this._documentService.getEmployees().
            subscribe((data) => {
                currentContext.employee.dataList = data.Table;
            });
        // console.log(sessionStorage.getItem('ID'));
        this.loading = false;
    }
    ResetEmployee() {
        this.EmployeeForm.reset();
        this.buttonDisabledReset = false;
        //this.buttonDisabledDelete = true
        this.submitted = false;
        this.sucess = false;
        this.Show = true;
        this.Temp = 1;
        this.EmpId = 0;
        this.loading = false;
        this.message = null;
    }
    SaveEmployee() {
        //debugger;
        this._documentService.SaveEmployee(JSON.stringify(this.EmployeeForm.value)).subscribe(
            (data) => {
                this.employee = data;
                if (this.employee.Flag = 1) {
                    sessionStorage.setItem('ID', this.employee.Flag.toString());
                    this.message = 'Record saved Successfully';
                    alert(this.message);
                }
                else {
                    this.message = 'Invalid Credential';
                    alert(this.message);
                }
                //this.EmployeeForm.reset();
                //this.loadAllDocuments();
                this.ResetEmployee();
                this.loadAllEmployees()
            }
        )
    }
    onRowClicked(data: any) {
        const Currentrowid = this.EmployeeForm.value;
        this.EmpId = data.EmpId;
        this.EmployeeForm.controls['EmployeeCode'].setValue(data.Emp_Code);
        this.EmployeeForm.controls['EmployeeName'].setValue(data.Emp_Name);
        this.EmployeeForm.controls['ContactNo'].setValue(data.PhoneNo);
        this.EmployeeForm.controls['EmailID'].setValue(data.EmailId);

        this.EmployeeForm.controls['DesignationId'].setValue(data.DesignationId);
        this.EmployeeForm.controls['IsActive'].setValue(data.IsActive);

        //this.buttonDisabledDelete = false;
        this.buttonDisabledReset = false;
        this.Temp = 2;
    }
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
    UpdateEmployee() {
        this._documentService.UpdateEmployee(JSON.stringify(this.EmployeeForm.value), this.EmpId).subscribe(
            (data) => {
                if (this.employee.Flag = 1) {
                    this.message = 'Record updated Successfully';
                    alert(this.message);
                    //this.buttonDisabledDelete = true;
                    this.buttonDisabledReset = false;
                }
                else {
                    this.message = 'Invalid Credential';
                    alert(this.message);
                }
                this.employee = data;
                this.Emplist = this.employee.dataList;
                //this.EmployeeForm.reset();
                this.ResetEmployee();
                this.loadAllEmployees();
            }
        )
    }
    onSubmit() {
        //debugger;
        //alert('OnSubmi Clicked');
        this.submitted = true;
        if (this.EmployeeForm.valid) {
            //this.sucess=true;
            const datat = this.EmployeeForm.value;

            if (this.Temp == 1) {
                this.SaveEmployee();
            }
            else {
                this.UpdateEmployee();
            }
        } else {
            this.validateAllFormFields(this.EmployeeForm);
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