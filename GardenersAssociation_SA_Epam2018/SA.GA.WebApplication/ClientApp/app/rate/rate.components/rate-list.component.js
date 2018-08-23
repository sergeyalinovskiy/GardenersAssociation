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
import { DataServiceRate } from '../../data-service/data.service.rate';
var RateListComponent = /** @class */ (function () {
    function RateListComponent(dataService) {
        this.dataService = dataService;
    }
    RateListComponent.prototype.ngOnInit = function () {
        this.load();
    };
    RateListComponent.prototype.load = function () {
        var _this = this;
        this.dataService.getRates().subscribe(function (data) { return _this.rates = data; });
    };
    RateListComponent.prototype.delete = function (id) {
        var _this = this;
        this.dataService.deleteRate(id).subscribe(function (data) { return _this.load(); });
    };
    RateListComponent = __decorate([
        Component({
            templateUrl: '../rate.template/rate-list.component.html',
            styleUrls: ['../../style/app.component.css']
        }),
        __metadata("design:paramtypes", [DataServiceRate])
    ], RateListComponent);
    return RateListComponent;
}());
export { RateListComponent };
//# sourceMappingURL=rate-list.component.js.map