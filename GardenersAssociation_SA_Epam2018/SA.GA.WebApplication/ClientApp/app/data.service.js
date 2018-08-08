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
        this.urlPlot = "/api/plots";
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
    DataService = __decorate([
        Injectable(),
        __metadata("design:paramtypes", [HttpClient])
    ], DataService);
    return DataService;
}());
export { DataService };
//# sourceMappingURL=data.service.js.map