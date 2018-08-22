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
import { DataServiceUser } from '../../data-service/data.service.user';
var NotActiveUserListComponent = /** @class */ (function () {
    function NotActiveUserListComponent(dataService) {
        this.dataService = dataService;
    }
    NotActiveUserListComponent.prototype.ngOnInit = function () {
        this.load();
    };
    NotActiveUserListComponent.prototype.load = function () {
        var _this = this;
        this.dataService.getNotActiveUsers().subscribe(function (data) { return _this.users = data; });
    };
    NotActiveUserListComponent.prototype.delete = function (id) {
        var _this = this;
        this.dataService.deleteUser(id).subscribe(function (data) { return _this.load(); });
    };
    NotActiveUserListComponent = __decorate([
        Component({
            templateUrl: '../user.template/user-list.component.html',
            styleUrls: ['../../style/app.component.css']
        }),
        __metadata("design:paramtypes", [DataServiceUser])
    ], NotActiveUserListComponent);
    return NotActiveUserListComponent;
}());
export { NotActiveUserListComponent };
//# sourceMappingURL=user-NotActiveList.component.js.map