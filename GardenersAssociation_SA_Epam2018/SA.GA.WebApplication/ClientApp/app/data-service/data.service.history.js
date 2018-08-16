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
var DataServiceHistory = /** @class */ (function () {
    function DataServiceHistory(http) {
        this.http = http;
        this.urlHistory = "/api/history";
    }
    DataServiceHistory.prototype.getUserPlots = function (id) {
        return this.http.get('/' + 'getPlots' + '/' + id);
    };
    DataServiceHistory.prototype.getPlotElectricity = function (id) {
        return this.http.get('/' + 'getPlotElectricity' + '/' + id);
    };
    DataServiceHistory.prototype.getHistorys = function () {
        return this.http.get(this.urlHistory);
    };
    DataServiceHistory.prototype.getHistory = function (id) {
        return this.http.get(this.urlHistory + '/' + id);
    };
    DataServiceHistory.prototype.createHistory = function (history) {
        return this.http.post(this.urlHistory, history);
    };
    DataServiceHistory.prototype.updateHistory = function (history) {
        return this.http.put(this.urlHistory + '/' + history.id, history);
    };
    DataServiceHistory.prototype.deleteHistory = function (id) {
        return this.http.delete(this.urlHistory + '/' + id);
    };
    DataServiceHistory = __decorate([
        Injectable(),
        __metadata("design:paramtypes", [HttpClient])
    ], DataServiceHistory);
    return DataServiceHistory;
}());
export { DataServiceHistory };
//# sourceMappingURL=data.service.history.js.map