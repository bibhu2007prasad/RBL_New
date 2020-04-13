import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { HolidayMasterService } from 'ClientApp/app/Services/holiday-master.service';
var HolidayMasterComponent = /** @class */ (function () {
    //  public selectUsers(event: any, user: any) {
    //    debugger;
    //   user.flag = !user.flag;
    //  }
    function HolidayMasterComponent(formbulider, holidayService) {
        this.formbulider = formbulider;
        this.holidayService = holidayService;
        this.dataSaved = false;
        this.holidayIdUpdate = null;
        // EmpId:string;
        this.buttonDisable = true;
        this.rowSelected = false;
    }
    HolidayMasterComponent.prototype.ngOnInit = function () {
        // debugger;
        this.holidayForm = this.formbulider.group({
            HolidayName: ['', [Validators.required]],
            Date: ['', [Validators.required]],
        });
        this.loadAllHolidays();
    };
    HolidayMasterComponent.prototype.loadAllHolidays = function () {
        this.allHolidays = this.holidayService.getAllHoliday();
    };
    HolidayMasterComponent.prototype.onFormSubmit = function () {
        this.dataSaved = false;
        var employee = this.holidayForm.value;
        this.CreateHoliday(this.holiday);
        this.holidayForm.reset();
    };
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
    HolidayMasterComponent.prototype.CreateHoliday = function (holiday) {
        var _this = this;
        if (this.holidayIdUpdate == null) {
            this.holidayService.SaveEmployee(holiday).subscribe(function () {
                _this.dataSaved = true;
                _this.message = 'Record saved Successfully';
                _this.loadAllHolidays();
                _this.holidayIdUpdate = null;
                _this.buttonDisable = true;
                _this.holidayForm.reset();
            });
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
    };
    HolidayMasterComponent = tslib_1.__decorate([
        Component({
            selector: 'app-holiday-master',
            templateUrl: './holiday-master.component.html',
            styleUrls: ['./holiday-master.component.css']
        }),
        tslib_1.__metadata("design:paramtypes", [FormBuilder, HolidayMasterService])
    ], HolidayMasterComponent);
    return HolidayMasterComponent;
}());
export { HolidayMasterComponent };
