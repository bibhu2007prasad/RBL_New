import { Component, OnInit, Inject } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Holiday } from 'ClientApp/app/Models/holiday';
import { HolidayMasterService } from 'ClientApp/app/Services/holiday-master.service';
import { UrlSegment } from '@angular/router';
import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Component({
  selector: 'app-holiday-master',
  templateUrl: './holiday-master.component.html',
  styleUrls: ['./holiday-master.component.css']
})
export class HolidayMasterComponent implements OnInit {
    holiday: Holiday;
    dataSaved = false;
    holidayForm: any;
    allHolidays: Observable<Holiday[]>;
    holidayIdUpdate = null;
    massage: null;
    message: string;
    holidayId : string;
    // EmpId:string;
    buttonDisable: boolean = true;
    rowSelected: boolean = false;
    //  public selectUsers(event: any, user: any) {
    //    debugger;
    //   user.flag = !user.flag;
    //  }
    constructor(private formbulider: FormBuilder, private holidayService: HolidayMasterService) { }

    ngOnInit() {
        // debugger;
        this.holidayForm = this.formbulider.group({
            HolidayName: ['', [Validators.required]],
            Date: ['', [Validators.required]],
           
        });
        this.loadAllHolidays();
    }
    loadAllHolidays() {
        this.allHolidays = this.holidayService.getAllHoliday();
    }
    onFormSubmit() {
        debugger;
        this.dataSaved = false;
        const holiday = this.holidayForm.value;
        this.CreateHoliday(holiday);
        this.holidayForm.reset();
    }
    //loadHolidayToEdit(holidayId: string) {
    //    this.buttonDisable = false;
    //    //debugger; 
    //    this.holidayService.getHolidayById(holidayId).subscribe(holiday => {
    //        this.massage = null;
    //        this.dataSaved = false;
    //        this.holidayId = holiday.HolidayId;
    //        this.holidayForm.controls['HolidayName'].setValue(holiday.HolidayName);
    //        this.holidayForm.controls['DateOfBirth'].setValue(holiday.Date);
    //       });

    //}


    CreateHoliday(holiday: Holiday) {
        if (this.holidayIdUpdate == null) {
            this.holidayService.SaveEmployee(holiday).subscribe(
                () => {
                    this.dataSaved = true;
                    this.message = 'Record saved Successfully';
                    this.loadAllHolidays();
                    this.holidayIdUpdate = null;
                    this.buttonDisable = true;
                    this.holidayForm.reset();
                }
            );
        }

        //CreateHoliday(holiday: Holiday) {
        //    if (this.holidayIdUpdate == null) {
        //        this.holidayService.createHoliday(holiday).subscribe(
        //            () => {
        //                this.dataSaved = true;
        //                this.message = 'Record saved Successfully';
        //                this.loadAllHolidays();
        //                this.holidayIdUpdate = null;
        //                this.buttonDisable = true;
        //                this.holidayForm.reset();
        //            }
        //        );
        //    } else {
        //        holiday.HolidayId = this.holidayIdUpdate;
        //        //this.holidayService.updateHoliday(holiday).subscribe(() => {
        //        //    this.dataSaved = true;
        //        //    this.massage = 'Record Updated Successfully';
        //        //    this.loadAllHolidays();
        //        //    this.holidayIdUpdate = null;
        //        //    this.buttonDisable = true;
        //        //    this.holidayForm.reset();
        //        //});

        //        this.holidayService.updateItem(JSON.stringify(this.holidayForm.value), this.Userid).subscribe(
        //            (data) => {
        //                if (this.holiday.Flag = 1) {
        //                    this.message = 'Record updated Successfully';
        //                    alert(this.message);
        //                    this.loadAllHolidays();
        //                    this.buttonDisabled1 = true;
        //                }
        //                else {
        //                    this.message = 'Invalid Credential';
        //                    alert(this.massage);
        //                }
        //                this.holiday = data;
        //                this.Emplist = this.holiday.dataList;

        //            }
        //        )
        //    }
        //}
        //// deleteEmployee(employeeId: string) {  
        //     //alert(this.holidayIdUpdate);
        //     if (confirm("Are you sure you want to delete this ?")) {   
        //     this.holidayService.deleteEmployeeById(employeeId).subscribe(() => {  
        //       this.dataSaved = true;  
        //       this.massage = 'Record Deleted Succefully';  
        //       this.loadAllEmployees();  
        //       this.holidayIdUpdate = null;  
        //       this.holidayForm.reset();  
        //       });  
        //     }  
        //  // alert(employeeId);
        // }  
        //deleteEmployee() {
        //    //alert(this.holidayIdUpdate);
        //    if (confirm("Are you sure you want to delete this ?")) {
        //        this.holidayService.deleteHolidayById(this.holidayIdUpdate).subscribe(() => {
        //            this.dataSaved = true;
        //            this.massage = 'Record Deleted Succefully';
        //            this.loadAllHolidays();
        //            this.holidayIdUpdate = null;
        //            this.buttonDisable = true;
        //            this.holidayForm.reset();
        //        });
        //    }
        //    // alert(employeeId);
        //}

        //deleteEmployee() {


        //    this.holidayService.deleteItem(this.Userid).subscribe(() => {
        //        if (this.holiday.Flag = 1) {
        //            this.message = 'Record deleted Successfully';
        //            alert(this.message);
        //            this.loadAllHolidays();

        //            this.buttonDisabled1 = true;
        //        }
        //        else {
        //            this.message = 'Invalid Credential';
        //            alert(this.message);
        //        }
        //    });
        //}
        //resetForm() {
        //    this.holidayForm.reset();
        //    this.massage = null;
        //    this.message = null;
        //    this.dataSaved = false;
        //    this.holidayIdUpdate = null;
        //    this.buttonDisable = true;
        //}
        //singleClickFunction() {
        //    debugger;
        //    //alert("Single click");

        //    this.rowSelected = true;
        //    event.preventDefault();
        //}

        // doubleClickFunction(employeeId: string){

        //   this.holidayService.getEmployeeById(employeeId).subscribe(employee=> {  
        //     this.massage = null;  
        //     this.dataSaved = false;  
        //     this.holidayIdUpdate = employee.EmpId;  
        //     this.holidayForm.controls['EmpName'].setValue(employee.EmpName);  
        //    this.holidayForm.controls['DateOfBirth'].setValue(employee.DateOfBirth);  
        //     this.holidayForm.controls['EmailId'].setValue(employee.EmailId);  
        //     this.holidayForm.controls['Gender'].setValue(employee.Gender);  
        //     this.holidayForm.controls['Address'].setValue(employee.Address);  
        //     this.holidayForm.controls['PinCode'].setValue(employee.PinCode);  
        //   });  
        //  // alert(employeeId);
        //   this.EmpId=employeeId;
        //   alert(this.EmpId);

        // }
    }
}  