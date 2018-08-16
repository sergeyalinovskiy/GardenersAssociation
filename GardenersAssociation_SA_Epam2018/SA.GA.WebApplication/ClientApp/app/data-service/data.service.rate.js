var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
var DataServiceRate = /** @class */ (function () {
    function DataServiceRate(http) {
        this.http = http;
        this.urlRate = "/api/rates";
    }
    DataServiceRate.prototype.getUserPlots = function (id) {
        return this.http.get('/' + 'getPlots' + '/' + id);
    };
    DataServiceRate.prototype.getPlotElectricity = function (id) {
        return this.http.get('/' + 'getPlotElectricity' + '/' + id);
    };
    DataServiceRate.prototype.getRates = function () {
        return this.http.get(this.urlRate);
    };
    DataServiceRate.prototype.getRate = function (id) {
        return this.http.get(this.urlRate + '/' + id);
    };
    DataServiceRate.prototype.createRate = function (rate) {
        return this.http.post(this.urlRate, rate);
    };
    DataServiceRate.prototype.updateRate = function (rate) {
        return this.http.put(this.urlRate + '/' + rate.id, rate);
    };
    DataServiceRate.prototype.deleteRate = function (id) {
        return this.http.delete(this.urlRate + '/' + id);
    };
    DataServiceRate.prototype.getRateInfo = function (id) {
        return this.http.get('/api/electricitys' + '/' + 'GetRateInfo' + '/' + id);
    };
    DataServiceRate = __decorate([
        Injectable(),
        __metadata("design:paramtypes", [HttpClient])
    ], DataServiceRate);
    return DataServiceRate;
}());
export { DataServiceRate };
//# sourceMappingURL=data.service.rate.js.map