import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { Document } from '../../models/Document/document';
import { DocumentMasterService } from 'ClientApp/app/Services/document-master.service';
var DocumentMasterComponent = /** @class */ (function () {
    function DocumentMasterComponent(formbulider, _documentService) {
        this.formbulider = formbulider;
        this._documentService = _documentService;
        this.Emplist = [];
        this.buttonDisabledReset = false; /*buttonDisabledDelete: boolean = true;*/
        this.submitted = false;
        this.sucess = false;
        this.Show = true;
        this.Temp = 1;
        this.DocumentTypeid = 0;
        this.loading = false;
        this.document = new Document();
        this.document.dataList = [];
    }
    DocumentMasterComponent.prototype.ngOnInit = function () {
        // debugger;
        this.DocumentForm = this.formbulider.group({
            DocumentCode: ['', [Validators.required]],
            DocumentName: ['', [Validators.required]],
            IsActive: ['', [Validators.required]],
        });
        this.setClickedRow = function (index) {
            this.selectedRow = index;
        };
        // this.AllEmployee();
        this.loadAllDocuments();
    };
    DocumentMasterComponent.prototype.isFieldValid = function (field) {
        return !this.DocumentForm.get(field).valid && this.DocumentForm.get(field).touched;
    };
    DocumentMasterComponent.prototype.displayFieldCss = function (field) {
        return {
            'validate': this.isFieldValid(field),
        };
    };
    DocumentMasterComponent.prototype.loadAllDocuments = function () {
        //debugger;
        this.loading = true;
        var currentContext = this;
        this._documentService.getDocuments().
            subscribe(function (data) {
            currentContext.document.dataList = data.Table;
        });
        // console.log(sessionStorage.getItem('ID'));
        this.loading = false;
    };
    DocumentMasterComponent.prototype.ResetDocument = function () {
        this.DocumentForm.reset();
        this.buttonDisabledReset = false;
        //this.buttonDisabledDelete = true
        this.submitted = false;
        this.sucess = false;
        this.Show = true;
        this.Temp = 1;
        this.DocumentTypeid = 0;
        this.loading = false;
        this.message = null;
    };
    DocumentMasterComponent.prototype.SaveDocument = function () {
        var _this = this;
        //debugger;
        this._documentService.SaveDocument(JSON.stringify(this.DocumentForm.value)).subscribe(function (data) {
            _this.document = data;
            if (_this.document.Flag = 1) {
                sessionStorage.setItem('ID', _this.document.Flag.toString());
                _this.message = 'Record saved Successfully';
                alert(_this.message);
            }
            else {
                _this.message = 'Invalid Credential';
                alert(_this.message);
            }
            //this.DocumentForm.reset();
            //this.loadAllDocuments();
            _this.ResetDocument();
            _this.loadAllDocuments();
        });
    };
    DocumentMasterComponent.prototype.onRowClicked = function (data) {
        var Currentrowid = this.DocumentForm.value;
        this.DocumentTypeid = data.DocumentTypeid;
        this.DocumentForm.controls['DocumentCode'].setValue(data.DocumentCode);
        this.DocumentForm.controls['DocumentName'].setValue(data.DocumentName);
        this.DocumentForm.controls['IsActive'].setValue(data.IsActive);
        //this.buttonDisabledDelete = false;
        this.buttonDisabledReset = false;
        this.Temp = 2;
    };
    //DeleteDesignation() {
    //    this._documentService.DeleteDocument(this.Userid).subscribe(() => {
    //        if (this.document.Flag = 1) {
    //            this.message = 'Record deleted Successfully';
    //            alert(this.message);
    //            this.loadAllDocuments();
    //            this.DocumentForm.reset();
    //            this.buttonDisabledDelete = true;
    //            this.buttonDisabledReset = false;
    //        }
    //        else {
    //            this.message = 'Invalid Credential';
    //            alert(this.message);
    //        }
    //    });
    //}
    DocumentMasterComponent.prototype.UpdateDocument = function () {
        var _this = this;
        this._documentService.UpdateDocument(JSON.stringify(this.DocumentForm.value), this.DocumentTypeid).subscribe(function (data) {
            if (_this.document.Flag = 1) {
                _this.message = 'Record updated Successfully';
                alert(_this.message);
                //this.buttonDisabledDelete = true;
                _this.buttonDisabledReset = false;
            }
            else {
                _this.message = 'Invalid Credential';
                alert(_this.message);
            }
            _this.document = data;
            _this.Emplist = _this.document.dataList;
            //this.DocumentForm.reset();
            _this.ResetDocument();
            _this.loadAllDocuments();
        });
    };
    DocumentMasterComponent.prototype.onSubmit = function () {
        //debugger;
        //alert('OnSubmi Clicked');
        this.submitted = true;
        if (this.DocumentForm.valid) {
            //this.sucess=true;
            var datat = this.DocumentForm.value;
            if (this.Temp == 1) {
                this.SaveDocument();
            }
            else {
                this.UpdateDocument();
            }
        }
        else {
            this.validateAllFormFields(this.DocumentForm);
        }
    };
    DocumentMasterComponent.prototype.validateAllFormFields = function (formGroup) {
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
    DocumentMasterComponent = tslib_1.__decorate([
        Component({
            selector: 'app-document-master',
            templateUrl: './document-master.component.html',
            styleUrls: ['./document-master.component.css']
        }),
        tslib_1.__metadata("design:paramtypes", [FormBuilder, DocumentMasterService])
    ], DocumentMasterComponent);
    return DocumentMasterComponent;
}());
export { DocumentMasterComponent };
