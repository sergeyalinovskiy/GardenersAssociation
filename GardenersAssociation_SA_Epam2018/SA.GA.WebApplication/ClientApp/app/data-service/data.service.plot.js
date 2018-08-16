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
var DataServicePlot = /** @class */ (function () {
    function DataServicePlot(http) {
        this.http = http;
        this.urlPlot = "/api/plot";
    }
    DataServicePlot.prototype.getPlots = function () {
        return this.http.get(this.urlPlot);
    };
    DataServicePlot.prototype.getPlot = function (id) {
        return this.http.get(this.urlPlot + '/' + id);
    };
    DataServicePlot.prototype.createPlot = function (plot) {
        return this.http.post(this.urlPlot, plot);
    };
    DataServicePlot.prototype.updatePlot = function (plot) {
        return this.http.put(this.urlPlot + '/' + plot.id, plot);
    };
    DataServicePlot.prototype.deletePlot = function (id) {
        return this.http.delete(this.urlPlot + '/' + id);
    };
    DataServicePlot.prototype.getUserPlots = function (id) {
        return this.http.get('/' + 'getPlots' + '/' + id);
    };
    DataServicePlot.prototype.getPlotElectricity = function (id) {
        return this.http.get('/' + 'getPlotElectricity' + '/' + id);
    };
    DataServicePlot = __decorate([
        Injectable(),
        __metadata("design:paramtypes", [HttpClient])
    ], DataServicePlot);
    return DataServicePlot;
}());
export { DataServicePlot };
//# sourceMappingURL=data.service.plot.js.map