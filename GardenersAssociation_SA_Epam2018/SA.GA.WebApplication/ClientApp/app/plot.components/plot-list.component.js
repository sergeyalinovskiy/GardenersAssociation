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
import { DataService } from '../data.service';
var PlotListComponent = /** @class */ (function () {
    function PlotListComponent(dataService) {
        this.dataService = dataService;
    }
    PlotListComponent.prototype.ngOnInit = function () {
        this.load();
    };
    PlotListComponent.prototype.load = function () {
        var _this = this;
        this.dataService.getPlots().subscribe(function (data) { return _this.plots = data; });
    };
    PlotListComponent.prototype.delete = function (id) {
        var _this = this;
        this.dataService.deletePlot(id).subscribe(function (data) { return _this.load(); });
    };
    PlotListComponent = __decorate([
        Component({
            templateUrl: '../plot.template/plot-list.component.html'
        }),
        __metadata("design:paramtypes", [DataService])
    ], PlotListComponent);
    return PlotListComponent;
}());
export { PlotListComponent };
//# sourceMappingURL=plot-list.component.js.map