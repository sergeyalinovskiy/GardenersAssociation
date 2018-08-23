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
import { Router } from '@angular/router';
import { DataServicePlot } from '../../data-service/data.service.plot';
import { Plot } from '../../models/plot';
var PlotCreateComponent = /** @class */ (function () {
    function PlotCreateComponent(dataService, router) {
        this.dataService = dataService;
        this.router = router;
        this.plot = new Plot(); // добавляемый объект
    }
    PlotCreateComponent.prototype.save = function () {
        var _this = this;
        this.dataService.createPlot(this.plot).subscribe(function (data) {
            return _this.router.navigateByUrl("/");
        });
    };
    PlotCreateComponent = __decorate([
        Component({
            templateUrl: '../plot.template/plot-create.component.html',
            styleUrls: ['../../style/app.component.css']
        }),
        __metadata("design:paramtypes", [DataServicePlot, Router])
    ], PlotCreateComponent);
    return PlotCreateComponent;
}());
export { PlotCreateComponent };
//# sourceMappingURL=plot-create.component.js.map