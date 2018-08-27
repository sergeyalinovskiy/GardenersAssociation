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
import { DataServiceSummary } from '../../data-service/data.service.summary';
import { Summary } from '../../models/summary';
var SummaryCreateComponent = /** @class */ (function () {
    function SummaryCreateComponent(dataService, router) {
        this.dataService = dataService;
        this.router = router;
        this.summary = new Summary(); // добавляемый объект
    }
    SummaryCreateComponent.prototype.save = function () {
        var _this = this;
        this.dataService.createSummary(this.summary).subscribe(function (data) {
            return _this.router.navigateByUrl("/");
        });
    };
    SummaryCreateComponent = __decorate([
        Component({
            templateUrl: '../summary.template/summary-create.component.html',
            styleUrls: ['../../style/app.component.css']
        }),
        __metadata("design:paramtypes", [DataServiceSummary, Router])
    ], SummaryCreateComponent);
    return SummaryCreateComponent;
}());
export { SummaryCreateComponent };
//# sourceMappingURL=summary-create.component.js.map