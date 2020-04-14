import * as tslib_1 from "tslib";
import { Component } from '@angular/core';
//import { IDropdownSettings } from 'ng-multiselect-dropdown';
var RegionMasterComponent = /** @class */ (function () {
    function RegionMasterComponent() {
    }
    RegionMasterComponent.prototype.ngOnInit = function () {
    };
    RegionMasterComponent = tslib_1.__decorate([
        Component({
            selector: 'app-region-master',
            templateUrl: './region-master.component.html',
            styleUrls: ['./region-master.component.css']
        }),
        tslib_1.__metadata("design:paramtypes", [])
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
