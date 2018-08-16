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
var DataServiceUser = /** @class */ (function () {
    function DataServiceUser(http) {
        this.http = http;
        this.urlUser = "/api/users";
    }
    DataServiceUser.prototype.getUsers = function () {
        return this.http.get(this.urlUser);
    };
    DataServiceUser.prototype.getUser = function (id) {
        return this.http.get(this.urlUser + '/' + id);
    };
    DataServiceUser.prototype.createUser = function (user) {
        return this.http.post(this.urlUser, user);
    };
    DataServiceUser.prototype.updateUser = function (user) {
        return this.http.put(this.urlUser + '/' + user.id, user);
    };
    DataServiceUser.prototype.deleteUser = function (id) {
        return this.http.delete(this.urlUser + '/' + id);
    };
    DataServiceUser.prototype.getUserPlots = function (id) {
        return this.http.get('/' + 'getPlots' + '/' + id);
    };
    DataServiceUser.prototype.getPlotElectricity = function (id) {
        return this.http.get('/' + 'getPlotElectricity' + '/' + id);
    };
    DataServiceUser = __decorate([
        Injectable(),
        __metadata("design:paramtypes", [HttpClient])
    ], DataServiceUser);
    return DataServiceUser;
}());
export { DataServiceUser };
//# sourceMappingURL=data.service.user.js.map