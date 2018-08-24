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
var DataServiceSummary = /** @class */ (function () {
    function DataServiceSummary(http) {
        this.http = http;
        this.urlSummary = "api/summary";
    }
    DataServiceSummary.prototype.getSummary = function () {
        return this.http.get(this.urlSummary);
    };
    DataServiceSummary.prototype.createSummary = function (summary) {
        return this.http.post(this.urlSummary, summary);
    };
    DataServiceSummary = __decorate([
        Injectable(),
        __metadata("design:paramtypes", [HttpClient])
    ], DataServiceSummary);
    return DataServiceSummary;
}());
export { DataServiceSummary };
//# sourceMappingURL=data.service.summary.js.map