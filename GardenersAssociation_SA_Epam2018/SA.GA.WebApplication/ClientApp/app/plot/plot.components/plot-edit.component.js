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
import { Router, ActivatedRoute } from '@angular/router';
import { DataServicePlot } from '../../data-service/data.service.plot';
var PlotEditComponent = /** @class */ (function () {
    function PlotEditComponent(dataService, router, activeRoute) {
        this.dataService = dataService;
        this.router = router;
        this.loaded = false;
        this.id = Number.parseInt(activeRoute.snapshot.params["id"]);
    }
    PlotEditComponent.prototype.ngOnInit = function () {
        var _this = this;
        if (this.id)
            this.dataService.getPlot(this.id)
                .subscribe(function (data) {
                _this.plot = data;
                if (_this.plot != null)
                    _this.loaded = true;
            });
    };
    PlotEditComponent.prototype.save = function () {
        var _this = this;
        this.dataService.updatePlot(this.plot).subscribe(function (data) { return _this.router.navigateByUrl("/"); });
    };
    PlotEditComponent = __decorate([
        Component({
            templateUrl: '../plot.template/plot-edit.component.html',
            styleUrls: ['../../style/app.component.css']
        }),
        __metadata("design:paramtypes", [DataServicePlot, Router, ActivatedRoute])
    ], PlotEditComponent);
    return PlotEditComponent;
}());
export { PlotEditComponent };
//# sourceMappingURL=plot-edit.component.js.map