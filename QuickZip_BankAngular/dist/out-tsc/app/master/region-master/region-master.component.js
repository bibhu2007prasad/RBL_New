import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
var RegionMasterComponent = /** @class */ (function () {
    function RegionMasterComponent() {
        this.dropdownList = [];
        this.selectedItems = [];
        this.dropdownSettings = {};
    }
    RegionMasterComponent.prototype.ngOnInit = function () {
        this.dropdownList = [
            { item_id: 1, item_text: 'Mumbai' },
            { item_id: 2, item_text: 'Bangaluru' },
            { item_id: 3, item_text: 'Pune' },
            { item_id: 4, item_text: 'Navsari' },
            { item_id: 5, item_text: 'New Delhi' }
        ];
        this.selectedItems = [
            { item_id: 3, item_text: 'Pune' },
            { item_id: 4, item_text: 'Navsari' }
        ];
        //this.dropdownSettings: IDropdownSettings = {
        //    singleSelection: false,
        //    idField: 'item_id',
        //    textField: 'item_text',
        //    selectAllText: 'Select All',
        //    unSelectAllText: 'UnSelect All',
        //    itemsShowLimit: 3,
        //    allowSearchFilter: true
        //};
    };
    RegionMasterComponent.prototype.onItemSelect = function (item) {
        console.log(item);
    };
    RegionMasterComponent.prototype.onSelectAll = function (items) {
        console.log(items);
    };
    RegionMasterComponent = tslib_1.__decorate([
        Component({
            selector: 'app-region-master',
            templateUrl: './region-master.component.html',
            styleUrls: ['./region-master.component.css']
        })
    ], RegionMasterComponent);
    return RegionMasterComponent;
}());
export { RegionMasterComponent };
