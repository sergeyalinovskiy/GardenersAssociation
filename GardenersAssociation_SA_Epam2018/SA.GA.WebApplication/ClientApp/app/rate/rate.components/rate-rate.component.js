//import { Component, OnInit } from '@angular/core';
//import { DataService } from '../../data.service';
//import { Router, ActivatedRoute } from '@angular/router';
//import { Rate } from '../../models/rate';
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
//@Component({
//    templateUrl: '../rate.template/rate-list.component.html'
//})
//export class RateComponent implements OnInit {
//    id: number;
//    rate: Rate;    // изменяемый объект
//    loaded: boolean = false;
//    constructor(private dataService: DataService, private router: Router, activeRoute: ActivatedRoute) {
//        this.id = Number.parseInt(activeRoute.snapshot.params["id"]);
//    }
//    ngOnInit() {
//        if (this.id)
//            this.dataService.getRateInfo(this.id)
//                .subscribe((data: Rate) => {
//                    this.rate = data;
//                    if (this.rate != null) this.loaded = true;
//                });
//    }
//}
import { Component } from '@angular/core';
import { DataService } from '../../data.service';
import { Router, ActivatedRoute } from '@angular/router';
var RateComponent = /** @class */ (function () {
    function RateComponent(dataService, router, activeRoute) {
        this.dataService = dataService;
        this.router = router;
        this.id = Number.parseInt(activeRoute.snapshot.params["id"]);
    }
    RateComponent.prototype.ngOnInit = function () {
        this.load();
    };
    RateComponent.prototype.load = function () {
        var _this = this;
        this.dataService.getRateInfo(this.id).subscribe(function (data) { return _this.rates = data; });
    };
    RateComponent.prototype.delete = function (id) {
        var _this = this;
        this.dataService.deleteRate(id).subscribe(function (data) { return _this.load(); });
    };
    RateComponent = __decorate([
        Component({
            templateUrl: '../rate.template/rate-list.component.html'
        }),
        __metadata("design:paramtypes", [DataService, Router, ActivatedRoute])
    ], RateComponent);
    return RateComponent;
}());
export { RateComponent };
//# sourceMappingURL=rate-rate.component.js.map