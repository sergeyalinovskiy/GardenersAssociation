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
var DataServiceElectricity = /** @class */ (function () {
    function DataServiceElectricity(http) {
        this.http = http;
        this.urlElectricity = "/api/electricitys";
    }
    DataServiceElectricity.prototype.getElectricitys = function () {
        return this.http.get(this.urlElectricity);
    };
    DataServiceElectricity.prototype.getElectricity = function (id) {
        return this.http.get(this.urlElectricity + '/' + id);
    };
    DataServiceElectricity.prototype.createElectricity = function (electricity) {
        return this.http.post(this.urlElectricity, electricity);
    };
    DataServiceElectricity.prototype.updateElectricity = function (electricity) {
        return this.http.put(this.urlElectricity + '/' + electricity.id, electricity);
    };
    DataServiceElectricity.prototype.deleteElectricity = function (id) {
        return this.http.delete(this.urlElectricity + '/' + id);
    };
    DataServiceElectricity.prototype.getRateInfo = function (id) {
        return this.http.get('/api/electricitys' + '/' + 'GetRateInfo' + '/' + id);
    };
    DataServiceElectricity.prototype.getUserPlots = function (id) {
        return this.http.get('/' + 'getPlots' + '/' + id);
    };
    DataServiceElectricity.prototype.getPlotElectricity = function (id) {
        return this.http.get('/' + 'getPlotElectricity' + '/' + id);
    };
    DataServiceElectricity = __decorate([
        Injectable(),
        __metadata("design:paramtypes", [HttpClient])
    ], DataServiceElectricity);
    return DataServiceElectricity;
}());
export { DataServiceElectricity };
//# sourceMappingURL=data.service.electricity.js.map