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
import { ActivatedRoute, Router } from '@angular/router';
var ElectricityPlotComponent = /** @class */ (function () {
    function ElectricityPlotComponent(dataService, router, activeRoute) {
        this.dataService = dataService;
        this.router = router;
        this.id = Number.parseInt(activeRoute.snapshot.params["id"]);
    }
    ElectricityPlotComponent.prototype.ngOnInit = function () {
        this.load();
    };
    ElectricityPlotComponent.prototype.load = function () {
        var _this = this;
        this.dataService.getPlotElectricity(this.id).subscribe(function (data) { return _this.electricitys = data; });
    };
    ElectricityPlotComponent.prototype.delete = function (id) {
        var _this = this;
        this.dataService.deleteElectricity(id).subscribe(function (data) { return _this.load(); });
    };
    ElectricityPlotComponent = __decorate([
        Component({
            templateUrl: '../electricity.template/electricity-plot.component.html'
        }),
        __metadata("design:paramtypes", [DataServiceElectricity, Router, ActivatedRoute])
    ], ElectricityPlotComponent);
    return ElectricityPlotComponent;
}());
export { ElectricityPlotComponent };
//# sourceMappingURL=electricity-plot.component.js.map