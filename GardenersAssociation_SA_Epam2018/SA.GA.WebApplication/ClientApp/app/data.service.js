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
var DataService = /** @class */ (function () {
    function DataService(http) {
        this.http = http;
        this.urlUser = "/api/users";
        this.urlPlot = "/api/plot";
        this.urlRate = "/api/rates";
        this.urlHistory = "/api/history";
        this.urlElectricity = "/api/electricitys";
    }
    DataService.prototype.getUsers = function () {
        return this.http.get(this.urlUser);
    };
    DataService.prototype.getUser = function (id) {
        return this.http.get(this.urlUser + '/' + id);
    };
    DataService.prototype.createUser = function (user) {
        return this.http.post(this.urlUser, user);
    };
    DataService.prototype.updateUser = function (user) {
        return this.http.put(this.urlUser + '/' + user.id, user);
    };
    DataService.prototype.deleteUser = function (id) {
        return this.http.delete(this.urlUser + '/' + id);
    };
    DataService.prototype.getPlots = function () {
        return this.http.get(this.urlPlot);
    };
    DataService.prototype.getPlot = function (id) {
        return this.http.get(this.urlPlot + '/' + id);
    };
    DataService.prototype.createPlot = function (plot) {
        return this.http.post(this.urlPlot, plot);
    };
    DataService.prototype.updatePlot = function (plot) {
        return this.http.put(this.urlPlot + '/' + plot.id, plot);
    };
    DataService.prototype.deletePlot = function (id) {
        return this.http.delete(this.urlPlot + '/' + id);
    };
    DataService.prototype.getElectricitys = function () {
        return this.http.get(this.urlElectricity);
    };
    DataService.prototype.getElectricity = function (id) {
        return this.http.get(this.urlElectricity + '/' + id);
    };
    DataService.prototype.createElectricity = function (electricity) {
        return this.http.post(this.urlElectricity, electricity);
    };
    DataService.prototype.updateElectricity = function (electricity) {
        return this.http.put(this.urlElectricity + '/' + electricity.id, electricity);
    };
    DataService.prototype.deleteElectricity = function (id) {
        return this.http.delete(this.urlElectricity + '/' + id);
    };
    DataService.prototype.getRates = function () {
        return this.http.get(this.urlRate);
    };
    DataService.prototype.getRate = function (id) {
        return this.http.get(this.urlRate + '/' + id);
    };
    DataService.prototype.createRate = function (rate) {
        return this.http.post(this.urlRate, rate);
    };
    DataService.prototype.updateRate = function (rate) {
        return this.http.put(this.urlRate + '/' + rate.id, rate);
    };
    DataService.prototype.deleteRate = function (id) {
        return this.http.delete(this.urlRate + '/' + id);
    };
    DataService.prototype.getHistorys = function () {
        return this.http.get(this.urlHistory);
    };
    DataService.prototype.getHistory = function (id) {
        return this.http.get(this.urlHistory + '/' + id);
    };
    DataService.prototype.createHistory = function (history) {
        return this.http.post(this.urlHistory, history);
    };
    DataService.prototype.updateHistory = function (history) {
        return this.http.put(this.urlHistory + '/' + history.id, history);
    };
    DataService.prototype.deleteHistory = function (id) {
        return this.http.delete(this.urlHistory + '/' + id);
    };
    DataService = __decorate([
        Injectable(),
        __metadata("design:paramtypes", [HttpClient])
    ], DataService);
    return DataService;
}());
export { DataService };
//# sourceMappingURL=data.service.js.map