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
import { DataServiceRate } from '../../data-service/data.service.rate';
import { Rate } from '../../models/rate';
var RateCreateComponent = /** @class */ (function () {
    function RateCreateComponent(dataService, router) {
        this.dataService = dataService;
        this.router = router;
        this.rate = new Rate(); // добавляемый объект
    }
    RateCreateComponent.prototype.save = function () {
        var _this = this;
        this.dataService.createRate(this.rate).subscribe(function (data) {
            return _this.router.navigateByUrl("/");
        });
    };
    RateCreateComponent = __decorate([
        Component({
            templateUrl: '../rate.template/rate-create.component.html',
            styleUrls: ['../../style/app.component.css']
        }),
        __metadata("design:paramtypes", [DataServiceRate, Router])
    ], RateCreateComponent);
    return RateCreateComponent;
}());
export { RateCreateComponent };
//# sourceMappingURL=rate-create.component.js.map