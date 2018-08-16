var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
import { Component } from '@angular/core';
import { DataServiceElectricity } from '../../data-service/data.service.electricity';
var ElectricityListComponent = /** @class */ (function () {
    function ElectricityListComponent(dataService) {
        this.dataService = dataService;
    }
    ElectricityListComponent.prototype.ngOnInit = function () {
        this.load();
    };
    ElectricityListComponent.prototype.load = function () {
        var _this = this;
        this.dataService.getElectricitys().subscribe(function (data) { return _this.electricitys = data; });
    };
    ElectricityListComponent.prototype.delete = function (id) {
        var _this = this;
        this.dataService.deleteElectricity(id).subscribe(function (data) { return _this.load(); });
    };
    ElectricityListComponent = __decorate([
        Component({
            templateUrl: '../electricity.template/electricity-list.component.html'
        }),
        __metadata("design:paramtypes", [DataServiceElectricity])
    ], ElectricityListComponent);
    return ElectricityListComponent;
}());
export { ElectricityListComponent };
//# sourceMappingURL=electricity-list.component.js.map