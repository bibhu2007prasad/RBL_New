import { Component, OnInit,Inject } from '@angular/core';
import {FormGroup, Validators, FormControl,FormBuilder} from '@angular/forms'
import { UrlSegment } from '@angular/router';
import { Observable } from 'rxjs'; 
import { HttpClient, HttpHeaders } from '@angular/common/http';
import {EmployeeServiceService} from './Services/employee-service.service'
import { Employee } from './employee';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
    Login: FormGroup; employee: Employee; Emplist = []; buttonDisabled1: boolean = true;  submitted = false; sucess = false; Show = true;
    Temp: number = 1; Userid: number = 0; loading: boolean = false;
    message: string;
    setClickedRow: Function;
    games: [{
        FullName: string,
        Email: string,
        Password: string
    }];
    constructor(private formBuilder: FormBuilder,private _employeeService: EmployeeServiceService) { 
    }

    ngOnInit() {

      this.Login = this.formBuilder.group ({
          FullName: ['', Validators.required],
          Email: ['', [Validators.required, Validators.email, Validators.pattern('^[a-z0-9._%+-]+@[a-z0-9.-]+\\.[a-z]{2,4}$')]],
          Password: ['', Validators.required]
          
        });
        this.setClickedRow = function (index) {
            this.selectedRow = index;
        }
        this.AllEmployee();
        
  }
  isFieldValid(field: string) {
    return !this.Login.get(field).valid && this.Login.get(field).touched;
  }
  displayFieldCss(field: string) {
    return {
      'validate': this.isFieldValid(field),
   };
  }
    AllEmployee() {
        this.loading = true;
        this._employeeService.getEmployees().
            subscribe((data) => {
               this.employee=data.Table;
            });
      // console.log(sessionStorage.getItem('ID'));
       this.loading = false;
    }

    

    SaveEmployee() {
        this._employeeService.SaveEmployee(JSON.stringify(this.Login.value)).subscribe(
            (data) => {
                this.employee = data;
                if (this.employee.Flag = 1) {
                    sessionStorage.setItem('ID',  this.employee.Flag.toString());
                    this.message = 'Record saved Successfully';
                    alert(this.message);
                }
                else {
                    this.message = 'Invalid Credential';
                    alert(this.message);
                }
                this.Login.reset();
                this.AllEmployee();  
            }
        )
    }
    onRowClicked(data: any) {
        const Currentrowid = this.Login.value;
        this.Userid=data.EmpId;
        this.Login.controls['FullName'].setValue(data.FullName);
        this.Login.controls['Email'].setValue(data.Email);
        this.Login.controls['Password'].setValue(data.Password);
        this.buttonDisabled1 = false;
        this.Temp = 2;
    }
    deleteEmp() {
        

        this._employeeService.deleteItem(this.Userid).subscribe(() => {
            if (this.employee.Flag = 1) {
                this.message = 'Record deleted Successfully';
                alert(this.message);
                this.AllEmployee();
                this.Login.reset();
                this.buttonDisabled1 = true;
            }
            else {
                this.message = 'Invalid Credential';
                alert(this.message);
            }
        });
    }
    updateItem() {
        this._employeeService.updateItem(JSON.stringify(this.Login.value), this.Userid).subscribe(
            (data) => {
                if (this.employee.Flag = 1) {
                    this.message = 'Record updated Successfully';
                    alert(this.message);
                    this.AllEmployee();
                    this.buttonDisabled1 = true;
                }
                else {
                    this.message = 'Invalid Credential';
                    alert(this.message);
                }
                this.employee = data;
                this.Emplist = this.employee.dataList;
                this.Login.reset();
            }
        )
    }
    onSubmit() {
        
 this.submitted=true;
 if (this.Login.valid) {
  //this.sucess=true;
  const datat = this.Login.value;
     if (this.Temp == 1) {
         this.SaveEmployee();

     }
    else {
         this.updateItem();
   }
  
} else {
  
  this.validateAllFormFields(this.Login); 
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





